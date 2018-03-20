using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Scheduleator
{
    public class ConsoleViewModel
    {
        #region Member Variables
        private HolderData holderData;
        private List<Shift> ShiftsForADAy = new List<Shift>();
        private List<Employee> _RegisteredEmployees = new List<Employee>();
        #endregion

        #region Properties
        public HolderData HolderData
        {
            get { return holderData; }
            set { holderData = value; }
        }
        #endregion

        #region Public Functions
        public List<Shift> ShiftList()
        {
            return ShiftsForADAy;
        }

        public void DeleteFromShiftList(int Index)
        {
            ShiftsForADAy.RemoveAt(Index);
        }

        public void AddShift(Shift newShfit)
        {
            ShiftsForADAy.Add(newShfit);
        }

        public List<Employee> EmployeeList()
        {
            return _RegisteredEmployees;
        }

        public int NumOfShift()
        {
            return ShiftsForADAy.Count;
        }

        public void InitializeViewModelData()
        {
            string JsonData;

            try
            {
                using (StreamReader streamReader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\ScheduleatorData.txt"))
                {
                    JsonData = streamReader.ReadToEnd();
                    holderData = JsonConvert.DeserializeObject<HolderData>(JsonData);
                }
            }
            catch { }

            if (null == holderData)
            {
                holderData = new HolderData();
            }

            if (holderData != null && holderData.CreatedShifts != null)
            {
                ShiftsForADAy = holderData.CreatedShifts;
                ShiftsForADAy = ShiftsForADAy.OrderBy(x => x.StartTime).ToList();
            }

            if (holderData != null && holderData.RegisteredEmployees != null)
            {
                _RegisteredEmployees = holderData.RegisteredEmployees;
            }
        }

        public string PrintSchedule()
        {
            string progPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); ;
            progPath += @"\Schedule.csv";

            using (StreamWriter outputfile = new StreamWriter(progPath))
            {
                foreach (Shift shift in ShiftsForADAy)
                {
                    outputfile.WriteLine("Shift ID"+"," + shift.ShiftID);
                    outputfile.WriteLine("Date" + "," + shift.DateOfShift.ToString("d", CultureInfo.CreateSpecificCulture("en-US")));
                    outputfile.WriteLine("Start Time: "+ "," + shift.StartTime.ToShortTimeString());
                    outputfile.WriteLine("End Time: " + "," + shift.EndTime.ToShortTimeString());
                    outputfile.WriteLine("Workers Required" + "," + shift.Coverage);
                    outputfile.WriteLine("Workers Scheduled"+ "," + shift.WorkingEmployees.Count);
                    outputfile.WriteLine("\r\nEmployees Scheduled: ");
                    outputfile.WriteLine("Employee Id" + "," + "Employee Name");

                    foreach (Employee employee in shift.WorkingEmployees)
                    {
                        outputfile.WriteLine(employee.ID +  ","  + employee.UserName + "\n");
                    }
                    outputfile.WriteLine("***************************\r\n");
                }
            }
            return progPath;
        }

        public void DisplayAllRegisteredUsers()
        {
            if (_RegisteredEmployees.Count == 0)
            {
                Console.WriteLine("\nNo Employees added\n");
            }
            else
            {
                foreach (Employee employee in _RegisteredEmployees)
                {
                    Console.WriteLine("\nEmployee ID: " + employee.ID);
                    Console.WriteLine("Employee Name: " + employee.UserName);
                    Console.WriteLine("************************************\r\n");
                }
            }
        }

        public void RegisterNewEmployee()
        {
            Employee newEmployee = new Employee();
            string response;

            Console.WriteLine("\nEnter Employee ID: ");
            newEmployee.ID = long.Parse(Console.ReadLine());
            Console.WriteLine("\rEmployee name: ");
            newEmployee.UserName = Console.ReadLine();
            Console.WriteLine("\nYou have entered following info" + "\n" + "ID: " + newEmployee.ID
                + " Name: " + newEmployee.UserName);
            Console.WriteLine("\rDo you want to add the employee to database? (Y/N): ");
            response = Console.ReadLine();

            if (response[0] == 'Y' || response[0] == 'y')
            {
                _RegisteredEmployees.Add(newEmployee);
                Console.WriteLine("Employee Successfully added\n");
            }
            else
            {
                Console.WriteLine("\rDiscarding the entered information\n");
            }
        }
        
        public void SetEmployeeAvailability()
        {
            Console.WriteLine("\nEnter Employee ID");
            long employeeId = long.Parse(Console.ReadLine());
            Employee EditingEmployee = new Employee();
            EditingEmployee = _RegisteredEmployees.Find(x => x.ID == employeeId);
            if (EditingEmployee != null)
            {
                Console.WriteLine(EditingEmployee.UserName);
                foreach (Shift shift in ShiftsForADAy)
                {
                    Console.WriteLine("\nShift Id: " + shift.ShiftID);
                    Console.WriteLine("Start Time: " + shift.StartTime.TimeOfDay.Hours + ":"
                        + shift.StartTime.TimeOfDay.Minutes + " and End Time: " + shift.EndTime.TimeOfDay.Hours + ":"
                        + shift.EndTime.TimeOfDay.Minutes);
                    Console.WriteLine("\nIs " + EditingEmployee.UserName + " available for this shift? (Y/N)");
                    string Isavailable = Console.ReadLine();
                    if (Isavailable[0] == 'y' || Isavailable[0] == 'Y')
                    {
                        shift.AddAvailableEmployee(EditingEmployee);
                    }
                }
            }
            else
            {
                Console.WriteLine("UserID not found\n");
            }
        }

        public void GenerateSchedule()
        {
            Console.WriteLine("\n***************************\r\n");
            Console.WriteLine("Generating Schedule");
            Console.WriteLine("\n***************************\r\n");

            foreach (Shift shift in ShiftsForADAy)
            {
                int i = shift.WorkingEmployees.Count;

                foreach (Employee employee in shift.AvailableEmployees)
                {

                    if (i < shift.Coverage)
                    {
                        if (!shift.WorkingEmployees.Exists(x => x.ID == employee.ID))
                        {
                            shift.AddWorkingEmployee(employee);
                            i++;
                        }
                    }
                    else
                    {
                        while(shift.WorkingEmployees.Count > shift.Coverage)
                        {
                            shift.WorkingEmployees.RemoveAt(0);
                        }
                    }
                }
            }
        }

        public void SaveScheduleProgress()
        {
            string progPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string JSONString = string.Empty;

            using (StreamWriter outputfile = new StreamWriter(progPath + @"\ScheduleatorData.txt"))
            {
                holderData.CreatedShifts = ShiftsForADAy;
                holderData.RegisteredEmployees = _RegisteredEmployees;
                JSONString = JsonConvert.SerializeObject(holderData);
                outputfile.WriteLine(JSONString);
            }
        }

        public void PrintAllShifts()
        {
            if (ShiftsForADAy.Count == 0)
            {
                Console.WriteLine("\nNo Shifts added\n");
            }
            else
            {
                foreach (Shift shift in ShiftsForADAy)
                {
                    Console.WriteLine("\nShift Id: " + shift.ShiftID);
                    Console.WriteLine("\rStart Time of Shift: " + shift.StartTime.ToShortTimeString());
                    Console.WriteLine("\rEnd Time of Shift: " + shift.EndTime.ToShortTimeString());
                    Console.WriteLine("\rLenght of Shift: " + shift.NumberOfHours.Hours + " hours and " +
                        shift.NumberOfHours.Minutes + " minutes");
                    Console.WriteLine("\r-----------------------------\n");
                }
            }
        }

        public void SaveUserInformation(Employee currentEmployee)
        {
            Employee employeeToChange = HolderData.RegisteredEmployees.Where(s => s.ID == currentEmployee.ID).First<Employee>();
            HolderData.RegisteredEmployees.Remove(employeeToChange);

            employeeToChange.UserName = currentEmployee.UserName;
            employeeToChange.ID = Convert.ToInt64(currentEmployee.ID);
            employeeToChange.PIN = currentEmployee.PIN;

            HolderData.RegisteredEmployees.Add(employeeToChange);
            SaveScheduleProgress();
        }
        #endregion
    }
}
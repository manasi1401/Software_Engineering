using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace Scheduleator
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ConsoleViewModel _ConsoleViewModel = new ConsoleViewModel();
            char choice = '0';

            _ConsoleViewModel.InitializeViewModelData();
            

            Console.WriteLine("Welcome to the Scheduleator! By: DropTables, LLC\n");
            while (choice != 'Q' || choice != 'q')
            {
                Console.WriteLine("S) Add a Shift\r");
                Console.WriteLine("L) List of Shifts\r");
                Console.WriteLine("A) Add an Employee\r");
                Console.WriteLine("E) Set Employee Availablity\r");
                Console.WriteLine("D) Display all Employee\r");
                Console.WriteLine("C) Save Progress\r");
                Console.WriteLine("G) Generate Schedule\r");
                Console.WriteLine("P) Print Schedule\r");
                Console.WriteLine("Q) Exit Scheduleator\r");

                Console.Write("\nPlease Enter Choice: ");
                choice = Console.ReadKey().KeyChar;            

                switch (choice)
                {
                    case 'C':
                    case 'c':
                        _ConsoleViewModel.SaveScheduleProgress();
                        break;
                    case 'G':
                    case 'g':
                        _ConsoleViewModel.GenerateSchedule();
                        break;
                    case 'E':
                    case 'e':
                        _ConsoleViewModel.SetEmployeeAvailability();
                        break;
                    case 'A':
                    case 'a':
                        _ConsoleViewModel.RegisterNewEmployee();
                        break;
                    case 'D':
                    case 'd':
                        _ConsoleViewModel.DisplayAllRegisteredUsers();
                        break;
                    case 'S':
                    case 's':
                        //_ConsoleViewModel.CreateNewShift();
                        break;
                    case 'L':
                    case 'l':
                        _ConsoleViewModel.PrintAllShifts();
                        break;
                    case 'P':
                    case 'p':
                        _ConsoleViewModel.PrintSchedule();
                        break;
                    case 'Q':
                    case 'q':
                        Console.WriteLine("\nQuitting the Scheduleator");
                        _ConsoleViewModel.SaveScheduleProgress();
                        Console.ReadLine();
                        return;

                    default:
                        Console.WriteLine("\nYou didn't pick an option. Please try again.\n");
                        break;
                }
            }

            Console.ReadLine();
        }
    }
}

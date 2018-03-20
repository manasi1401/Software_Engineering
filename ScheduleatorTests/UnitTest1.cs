using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scheduleator;

namespace ScheduleatorTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddUserTest()
        {
            Employee testObject = new Employee();
            testObject.UserName = "Joe";
            Assert.AreEqual("Joe", testObject.UserName);
        }

        [TestMethod] 
        public void AddShiftStartTime()
        {
            Shift testShift = new Shift();

            testShift.ShiftID = 9;
            Assert.AreEqual(9, testShift.ShiftID);
            testShift.Coverage = 0;
            Assert.AreEqual(0, testShift.Coverage);
        }

        [TestMethod]
        public void TestShiftMonth()
        {
            Shift testShift = new Shift();

            testShift.EndTime = new DateTime(2017, 10, 23, 5, 5, 5);

            Assert.AreEqual(testShift.EndTime.Month, 10);
        }

		[TestMethod]
		public void TestShiftEndTimes()
		{
			Shift testShift = new Shift();

			testShift.EndTime = new DateTime(2017, 10, 23, 0, 0, 0);

			Assert.AreEqual(testShift.EndTime.Hour, 0);
			Assert.AreEqual(testShift.EndTime.Minute, 0);
			Assert.AreEqual(testShift.EndTime.Second, 0);

		}

		[TestMethod]
		public void TestShiftStartTime()
		{
			Shift testShift = new Shift();

			testShift.StartTime = new DateTime(2017, 10, 22, 10, 30, 0);

			Assert.AreEqual(testShift.StartTime.Hour, 10);
			Assert.AreEqual(testShift.StartTime.Minute, 30);
			Assert.AreEqual(testShift.StartTime.Second, 0);
		}

	}
}

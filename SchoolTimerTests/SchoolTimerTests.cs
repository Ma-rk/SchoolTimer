using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SchoolTimer.Tests
{
    [TestClass()]
    public class SchoolTimerTests
    {
        [TestMethod()]
        public void CheckWorkingHourTest()
        {
            SchoolTimer timer = new SchoolTimer();

            DateTime dt = new DateTime(2017, 1, 1, 0, 0, 0);
            Assert.IsFalse(timer.CheckWorkingHour(dt));

            dt = new DateTime(2017, 1, 1, 7, 59, 59);
            Assert.IsFalse(timer.CheckWorkingHour(dt));

            dt = new DateTime(2017, 1, 1, 8, 0, 0);
            Assert.IsTrue(timer.CheckWorkingHour(dt));

            dt = new DateTime(2017, 1, 1, 8, 0, 1);
            Assert.IsTrue(timer.CheckWorkingHour(dt));

            dt = new DateTime(2017, 1, 1, 12, 0, 0);
            Assert.IsTrue(timer.CheckWorkingHour(dt));

            dt = new DateTime(2017, 1, 1, 17, 59, 59);
            Assert.IsTrue(timer.CheckWorkingHour(dt));

            dt = new DateTime(2017, 1, 1, 18, 0, 0);
            Assert.IsFalse(timer.CheckWorkingHour(dt));

            dt = new DateTime(2017, 1, 1, 18, 0, 1);
            Assert.IsFalse(timer.CheckWorkingHour(dt));

            dt = new DateTime(2017, 1, 1, 23, 59, 59);
            Assert.IsFalse(timer.CheckWorkingHour(dt));
        }
    }
}
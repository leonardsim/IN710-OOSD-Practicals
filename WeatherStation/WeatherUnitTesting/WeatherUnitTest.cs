using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherStation;
using System.Windows.Forms;


namespace WeatherUnitTesting
{
    [TestClass]
    public class WeatherUnitTest
    {
        [TestMethod]
        public void Update_AvgReadings_ReturnExpectedValue()
        {
            ListBox lb = new ListBox();
            WeatherSubject subject = new WeatherSubject();
            AverageObserver aO = new AverageObserver(lb, subject);

            aO.Update(12, 1, 1);
            aO.Update(20, 1, 1);

            double expected = 16;
            double actual = aO.ComputedTemp;

            Assert.AreEqual(expected, actual);
        }
    }
}

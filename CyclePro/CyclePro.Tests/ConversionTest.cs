using System;
using CyclePro.Helper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CyclePro.Tests
{
    /// <summary>
    /// Test all extension methods within the ConvertDistance class.
    /// </summary>
    [TestClass]
    public class ConversionTest
    {
        /// <summary>
        /// Testing conversion between meters (m) to feet (ft).
        /// </summary>
        [TestMethod]
        public void ConvertMetersToFeet()
        {
            const double feet = 10.1;
            var meters = feet.ConvertFeetToMeters();

            Assert.AreEqual(3.08, Math.Round(meters, 2));
        }

        /// <summary>
        /// Testing conversion to feet (ft) back to meters (m). 
        /// </summary>
        [TestMethod]
        public void ConvertFeetToMeters()
        {
            const double meters = 10.5;
            var feet = meters.ConvertMetersToFeet();

            Assert.AreEqual(34.45, Math.Round(feet, 2));
        }

        /// <summary>
        /// Testing conversion miles (mph) to Kilometers (kph).
        /// </summary>
        [TestMethod]
        public void ConvertMilesToKilometers()
        {
            const double miles = 20.5;
            var kilometers = miles.ConvertMilesToKilometers();

            Assert.AreEqual(33, Math.Round(kilometers));
        }

        /// <summary>
        /// CTesting conversion from Kilometers (kph) to miles (mph)
        /// </summary>
        [TestMethod]
        public void ConvertKilometersToMiles()
        {
            const double kilometers = 30.5;
            var miles = kilometers.ConvertKilometersToMiles();

            Assert.AreEqual(18.95, Math.Round(miles, 2));
        }
    }
}

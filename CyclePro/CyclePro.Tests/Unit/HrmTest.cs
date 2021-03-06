﻿using System;
using System.Linq;
using CyclePro.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CyclePro.Tests.Unit
{
    [TestClass]
    public class HrmTest
    {
        public Hrm DataHrm;

        public HrmTest()
        {
            //Set default Hrm instance for testing.
            var testData =  System.IO.File.ReadAllText(@"TestFile.hrm");
            DataHrm =       new Hrm(testData);
        }
        /// <summary>
        /// Verify that the HRM data can be set with new HRM instance.
        /// </summary>
        [TestMethod]
        public void SetHrmDataWithConstructor()
        {
            
        }

        /// <summary>
        /// Verify that the static DateTimeForm transforms data and time in string 
        /// and returns a DateTime object
        /// <returns>DateTime</returns>
        /// </summary>
        [TestMethod]
        public void DateTimeFormat()
        {
            //Set date and time through set method
            var dateTime =  DataHrm.Parameters.SetDateTime("20130205", "15:46:20.0");
            var eDateTime = new DateTime(2013,02,05, 15,46,20);

            //Verify the date time matches the exact date time values created with c# DateTime
            Assert.AreEqual(dateTime, eDateTime);
            Assert.AreEqual(dateTime.GetType(), typeof (DateTime));
        }

        /// <summary>
        /// Verify the static method in Hrm returns the correct model name for the 
        /// model id when passed as the index value
        /// </summary>
        [TestMethod]
        public void GetModelName()
        {
            //Get two different model names using the model dictionary
            var model =     DataHrm.Parameters.ModelName[3];
            var nmodel =    DataHrm.Parameters.ModelName[34];

            Assert.AreEqual("Accurex Plus", model);
            Assert.AreEqual("CS600X", nmodel);
        }

        /// <summary>
        /// Verifying that the default constructor has correctly defined the recorded features.
        /// </summary>
        [TestMethod]
        public void SetHrmFeatures()
        {
            //Assert all features have been verified.
            Assert.IsTrue(DataHrm.Features.Altitude, "Expecting Altitude to be True");
            Assert.IsTrue(DataHrm.Features.Euro, "Expecting Euro to be True");
            Assert.IsTrue(DataHrm.Features.Cadence, "Expecting Cadence to be True");
            Assert.IsTrue(DataHrm.Features.Speed, "Expecting Speed to be True");
            Assert.IsTrue(DataHrm.Features.Power, "Expecting Power to be True");
            Assert.IsFalse(DataHrm.Features.Pressure, "Expecting Pressure to be False");
            Assert.IsFalse(DataHrm.Features.Hr, "Expecting Heart Rate to be False");
        }

        /// <summary>
        /// Verifying that the default constructor has correctly defined all parameters.
        /// </summary>
        [TestMethod]
        public void ConfirmHrmParameters()
        {
            //Assert all parameters have been given a value
            Assert.IsNotNull(DataHrm.Parameters.Monitor);    
            Assert.IsNotNull(DataHrm.Parameters.SMode);    
            Assert.IsNotNull(DataHrm.Parameters.StartDateTime);    
            Assert.IsNotNull(DataHrm.Parameters.Length);    
            Assert.IsNotNull(DataHrm.Parameters.Interval);    
            Assert.IsNotNull(DataHrm.Parameters.Upper1);    
            Assert.IsNotNull(DataHrm.Parameters.Upper2);    
            Assert.IsNotNull(DataHrm.Parameters.Upper3);    
            Assert.IsNotNull(DataHrm.Parameters.Lower1);    
            Assert.IsNotNull(DataHrm.Parameters.Lower2);    
            Assert.IsNotNull(DataHrm.Parameters.Lower3);    
            Assert.IsNotNull(DataHrm.Parameters.Timer1);    
            Assert.IsNotNull(DataHrm.Parameters.Timer2); 
            Assert.IsNotNull(DataHrm.Parameters.Version);
            Assert.IsNotNull(DataHrm.Parameters.ActiveLimit);
            Assert.IsNotNull(DataHrm.Parameters.MaxHr);
            Assert.IsNotNull(DataHrm.Parameters.RestHr);
            Assert.IsNotNull(DataHrm.Parameters.StartDelay);
            Assert.IsNotNull(DataHrm.Parameters.Vo2Max);
            Assert.IsNotNull(DataHrm.Parameters.Weight);
        }

        /// <summary> 
        /// Verify that the Hrm parameters can retrieved successfully from the input file.
        /// </summary>
        [TestMethod]
        public void GetHrmParameters()  
        {
            //Load test file and get stream
            var file =      System.IO.File.ReadAllText(@"TestFile.hrm");

            //Use method to get the parameters for version and interval
            var version =   DataHrm.Parameters.GetHrmParameter(file, "Version");
            var interval =  DataHrm.Parameters.GetHrmParameter(file, "Interval");

            //Verify they are as expected.
            Assert.AreEqual(version, "106");
            Assert.AreEqual(interval, "1");
        }

        /// <summary>
        /// Verify that the parameters can be set through the SetParameters method.
        /// </summary>
        [TestMethod]
        public void SetHrmParameters()
        {
            //Load Test file and get current version
            var fileStream =        System.IO.File.ReadAllText(@"TestFile.hrm");
            var originalVersion =   DataHrm.Parameters.Version; 

            //Manually changed the objects version
            DataHrm.Parameters.Version = 1.05;
            var newVersion =        DataHrm.Parameters.Version; 

            //Rerun the set parameters method to check it reloads the correct parameter
            DataHrm.Parameters =    new HrmParameters(fileStream);
            var finalVersion =      DataHrm.Parameters.Version;

            //Assert
            Assert.AreNotEqual(originalVersion, newVersion);
            Assert.AreEqual(originalVersion, finalVersion);
        }


        /// <summary>
        /// Get the average value for a given data parameter
        /// </summary>
        [TestMethod]
        public void GetAverageValue()
        {
            var speed =     DataHrm.GetAverage("speed");
            var hr =        DataHrm.GetAverage("hr");
            var cadence =   DataHrm.GetAverage("cadence");
            var altitude =  DataHrm.GetAverage("altitude");
            var power =     DataHrm.GetAverage("power");
            var pressure =  DataHrm.GetAverage("pressure");
            var distance =  DataHrm.GetAverage("distance"); 

            Assert.AreEqual(20.11, speed, "Speed");
            Assert.AreEqual(132.67, hr, "Heart Rate");
            Assert.AreEqual(49.26, cadence, "Cadence");
            Assert.AreEqual(-94.51, altitude, "Altitude");
            Assert.AreEqual(121.52, power, "Power");
            Assert.AreEqual(3000.42, pressure, "Pressure");
            Assert.AreEqual(0.01, distance, "Distance");
        }

        /// <summary>
        /// Get the highest value for a given data parameter
        /// </summary>
        [TestMethod]
        public void GetHighestValue()
        {
            var speed =     DataHrm.GetHighest("speed");
            var hr =        DataHrm.GetHighest("hr");
            var cadence =   DataHrm.GetHighest("cadence");
            var altitude =  DataHrm.GetHighest("altitude");
            var power =     DataHrm.GetHighest("power");
            var pressure =  DataHrm.GetHighest("pressure");
            var distance =  DataHrm.GetHighest("distance");

            Assert.AreEqual(50.8, Math.Round(speed, 2), "Speed");
            Assert.AreEqual(162, hr, "Heart Rate");
            Assert.AreEqual(102, cadence, "Cadence");
            Assert.AreEqual(50.8, Math.Round(altitude, 2), "Altitude");
            Assert.AreEqual(440, power, "Power");
            Assert.AreEqual(19249, pressure, "Pressure");
            Assert.AreEqual(0.01, Math.Round(distance, 2), "Distance");
        }

        /// <summary>
        /// Get the lowest value for a given data parameter
        /// </summary>
        [TestMethod]
        public void GetLowestValue()
        {
            var speed =     DataHrm.GetLowest("speed");
            var hr =        DataHrm.GetLowest("hr");
            var cadence =   DataHrm.GetLowest("cadence");
            var altitude =  DataHrm.GetLowest("altitude");
            var power =     DataHrm.GetLowest("power");
            var pressure =  DataHrm.GetLowest("pressure");
            var distance =  DataHrm.GetLowest("distance");

            Assert.AreEqual(0, speed, "Speed");
            Assert.AreEqual(98, hr, "Heart Rate");
            Assert.AreEqual(0, cadence, "Cadence");
            Assert.AreEqual(0, altitude, "Altitude");
            Assert.AreEqual(0, power, "Power");
            Assert.AreEqual(50, pressure, "Pressure");
            Assert.AreEqual(0, distance, "Distance");
        }

        /// <summary>
        /// Test the switch metric correctly checks the current unit value and switches to metric.
        /// </summary>
        [TestMethod]
        public void SwitchUnitToMetric()
        {
            var speed =         DataHrm.Data.First().Speed;
            var distance =      DataHrm.Data.First().Distance;
            var tDistance =     DataHrm.Data.First().TotalDistance;
            var altitude =      DataHrm.Data.First().Altitude;

            Hrm.SwitchMetric(DataHrm);

            var nSpeed =        DataHrm.Data.First().Speed;
            var nDistance =     DataHrm.Data.First().Distance;
            var nTDistance =    DataHrm.Data.First().TotalDistance;
            var nAltitude =     DataHrm.Data.First().Altitude;

            Assert.AreNotEqual(speed, nSpeed);
            Assert.AreNotEqual(distance, nDistance);
            Assert.AreNotEqual(tDistance, nTDistance);
            Assert.AreNotEqual(altitude, nAltitude);
        }

        /// <summary>
        /// Test the switch metric correctly checks the current unit value and switches to imperial.
        /// </summary>
        public void SwitchUnitToImperial()
        {
            DataHrm.Features.Euro = false;

            var speed =         DataHrm.Data.First().Speed;
            var distance =      DataHrm.Data.First().Distance;
            var tDistance =     DataHrm.Data.First().TotalDistance;
            var altitude =      DataHrm.Data.First().Altitude;

            Hrm.SwitchMetric(DataHrm);

            var nSpeed =        DataHrm.Data.First().Speed;
            var nDistance =     DataHrm.Data.First().Distance;
            var nTDistance =    DataHrm.Data.First().TotalDistance;
            var nAltitude =     DataHrm.Data.First().Altitude;

            Assert.AreNotEqual(speed, nSpeed);
            Assert.AreNotEqual(distance, nDistance);
            Assert.AreNotEqual(tDistance, nTDistance);
            Assert.AreNotEqual(altitude, nAltitude);
        }
    }
}
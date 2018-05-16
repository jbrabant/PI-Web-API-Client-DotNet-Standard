// ************************************************************************
//
// * Copyright 2017 OSIsoft, LLC
// * Licensed under the Apache License, Version 2.0 (the "License");
// * you may not use this file except in compliance with the License.
// * You may obtain a copy of the License at
// * 
// *   <http://www.apache.org/licenses/LICENSE-2.0>
// * 
// * Unless required by applicable law or agreed to in writing, software
// * distributed under the License is distributed on an "AS IS" BASIS,
// * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// * See the License for the specific language governing permissions and
// * limitations under the License.
// ************************************************************************

using NUnit.Framework;
using OSIsoft.PIDevClub.PIWebApiClient.Api;
using OSIsoft.PIDevClub.PIWebApiClient.Model;
using System.Collections.Generic;

namespace OSIsoft.PIDevClub.PIWebApiClient.Test
{
    /// <summary>
    ///  Class for testing CalculationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CalculationApiTests : CommonApi
    {
        private ICalculationApi instance;
        private string webId;
        private string expression = "'sinusoid'*2 - 40";
        private string startTime = "*-1d";
        private string endTime = "*";

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            base.CommonInit();
            webId = client.DataServer.GetByPath(Constants.PI_DATA_SERVER_PATH).WebId;
            instance = client.Calculation;
            base.CreateSampleDatabaseForTests();

        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
            base.DeleteSampleDatabaseForTests();
        }

        /// <summary>
        /// Test an instance of CalculationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf(typeof(CalculationApi), instance, "instance is a CalculationApi");
        }


        /// <summary>
        /// Test GetAtIntervals
        /// </summary>
        [Test]
        public void GetAtIntervalsTest()
        {
            string sampleInterval = "1h";
            string selectedFields = null;
            var response = instance.GetAtIntervals(webId: webId, expression: expression, startTime: startTime, endTime: endTime, sampleInterval: sampleInterval, selectedFields: selectedFields);
            Assert.IsInstanceOf<PITimedValues>(response, "response is PITimedValues");
            Assert.IsTrue(response.Items.Count > 0);
        }

        /// <summary>
        /// Test GetAtRecorded
        /// </summary>
        [Test]
        public void GetAtRecordedTest()
        {
            string selectedFields = null;
            var response = instance.GetAtRecorded(webId: webId, expression: expression, startTime: startTime, endTime: endTime, selectedFields: selectedFields);
            Assert.IsInstanceOf<PITimedValues>(response, "response is PITimedValues");
            Assert.IsTrue(response.Items.Count > 0);
        }

        /// <summary>
        /// Test GetAtTimes
        /// </summary>
        [Test]
        public void GetAtTimesTest()
        {
            List<string> time = new List<string>() { "*-4d", "*-3d", "*-2d" };
            string sortOrder = null;
            string expression = "2*'sinusoid'";
            string selectedFields = null;
            var response = instance.GetAtTimes(expression: expression, selectedFields: selectedFields, sortOrder: sortOrder, time: time, webId: webId);
            Assert.IsInstanceOf<PITimedValues>(response, "response is PITimedValues");
            Assert.IsTrue(response.Items.Count > 0);
        }

        /// <summary>
        /// Test GetSummary
        /// </summary>
        [Test]
        public void GetSummaryTest()
        {
            List<string> summaryType = null;
            string calculationBasis = null;
            string timeType = null;
            string summaryDuration = null;
            string sampleType = null;
            string sampleInterval = null;
            string selectedFields = null;
            var response = instance.GetSummary(calculationBasis, endTime, expression, sampleInterval, sampleType, selectedFields, startTime, summaryDuration, summaryType, timeType, webId);
            Assert.IsInstanceOf<PIItemsSummaryValue>(response, "response is PIItemsSummaryValue");
            Assert.IsTrue(response.Items.Count > 0);
        }

    }

}
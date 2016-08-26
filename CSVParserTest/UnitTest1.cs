using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CSVParser;
using System.Collections.Generic;

namespace CSVParserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PositiveTest()
        {
            List<Employee> employees = new List<Employee>();
            bool isInValid = false;


            employees = CSVReader.getEmployees("PositiveTest.csv", out isInValid);

            Assert.AreEqual(isInValid, false);
        }
        [TestMethod]
        public void AmountInvalidTest()
        {
            List<Employee> employees = new List<Employee>();
            bool isInValid = false;


            employees = CSVReader.getEmployees("AmountInvalid.csv", out isInValid);

            Assert.AreEqual(isInValid, true);
        }
        [TestMethod]
        public void FieldMissingTest()
        {
            List<Employee> employees = new List<Employee>();
            bool isInValid = false;


            employees = CSVReader.getEmployees("FieldMissing.csv", out isInValid);

            Assert.AreEqual(isInValid, true);
        }
        [TestMethod]
        public void SalaryLessThanZeroTest()
        {
            List<Employee> employees = new List<Employee>();
            bool isInValid = false;


            employees = CSVReader.getEmployees("SalaryLessThanZero.csv", out isInValid);

            Assert.AreEqual(isInValid, true);
        }
        [TestMethod]
        public void DateInvalidTest()
        {
            List<Employee> employees = new List<Employee>();
            bool isInValid = false;


            employees = CSVReader.getEmployees("DateInvalid.csv", out isInValid);

            Assert.AreEqual(isInValid, true);
        }
    }
}

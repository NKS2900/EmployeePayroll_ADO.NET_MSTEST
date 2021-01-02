using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeePayroll_ADO.NET_MSTEST;
using System;

namespace EmployeePayrollTestCases
{
    [TestClass]
    public class PayrollTest
    {
        /// <summary>
        /// Check Connection Established With database or not
        /// </summary>
        [TestMethod]
        public void ChekConnection()
        {
            EmployeeRepo emprepo = new EmployeeRepo();
            bool result = emprepo.EstablishConnection();
            bool expect = true;
            Assert.AreEqual(result, expect);
        }

        /// <summary>
        /// Given Employee Payroll Service DB when Retrive then return Count of employee
        /// </summary>
        [TestMethod]
        public void GivenPayrollServiceDB_WhenRetrieve_ThenReturnPayrollServiceFromDataBase()
        {
            EmployeeRepo emprepo = new EmployeeRepo();
            int result = emprepo.GetAllRecords();
            int expect = 7;
            Assert.AreEqual(result, expect);
        }

        /// <summary>
        /// Givens the employee name when update salary then return employee payroll from data base.
        /// </summary>
        [TestMethod]
        public void GivenEmployeeName_WhenUpdateSalary_ThenReturnExpectedSalary()
        {
            EmployeeRepo emprepo = new EmployeeRepo();
            double expect = emprepo.UpdateEmployee();
            int result = 3000000;
            Assert.AreEqual(result, expect);
        }

        /// <summary>
        /// retrive employee who joined in perticular date range.
        /// </summary>
        [TestMethod]
        public void GivenEmployeeStartDate_ThenReturnTotalEmployeeBetweenRange()
        {
            EmployeeRepo emprepo = new EmployeeRepo();
            int count = emprepo.getEmployeeDataWithGivenRange();
            int expected = 4;
            Assert.AreEqual(expected, count);
        }

        /// <summary>
        /// Givens the employee names when update salary then return expected sum salary.
        /// </summary>
        [TestMethod]
        public void GivenEmployeeNames_WhenUpdateSalary_ThenReturnExpectedSumSalary()
        {
            int expected = 3365000;
            EmployeeRepo emprepo = new EmployeeRepo();
            int sum = emprepo.getAggrigateSumSalary();
            Assert.AreEqual(expected, sum);
        }

        /// <summary>
        /// Givens the employee names when average salary then return expected average salary.
        /// </summary>
        [TestMethod]
        public void GivenEmployeeNames_WhenAvgSalary_ThenReturnExpectedAvgSalary()
        {
            int expected = 841250;
            EmployeeRepo emprepo = new EmployeeRepo();
            int avg = emprepo.getAvragSalary();
            Assert.AreEqual(expected, avg);
        }

        /// <summary>
        /// Givens the employee names when minimum salary then return expected minimum salary.
        /// </summary>
        [TestMethod]
        public void GivenEmployeeNames_WhenMinSalary_ThenReturnExpectedMinSalary()
        {
            int expected = 65000;
            EmployeeRepo emprepo = new EmployeeRepo();
            int min = emprepo.getMinSalary();
            Assert.AreEqual(expected, min);
        }

        /// <summary>
        /// Givens the employee names when maximum then return expected maximum salary.
        /// </summary>
        [TestMethod]
        public void GivenEmployeeNames_WhenMax_ThenReturnExpectedMaxSalary()
        {
            int expected = 3000000;
            EmployeeRepo emprepo = new EmployeeRepo();
            int max = emprepo.getMaxSalary();
            Assert.AreEqual(expected, max);
        }

        /// <summary>
        /// Givens the employee names when count by salary then return expected count by salary.
        /// </summary>
        [TestMethod]
        public void GivenEmployeeNames_WhenCountBySalary_ThenReturnExpectedCountBySalary()
        {
            int expected = 4;
            EmployeeRepo emprepo = new EmployeeRepo();
            int count = emprepo.getCountSalary();
            Assert.AreEqual(expected, count);
        }

        /// <summary>
        /// Givens the employee names when count by salary then return expected count by salary.
        /// </summary>
        [TestMethod]
        public void GivenEmployeeNamess_WhenCountBySalary_ThenReturnExpectedCountBySalary()
        {
            bool expected = true;
            EmployeeRepo employeePayrollRepo = new EmployeeRepo();
            EmployeeModel model = new EmployeeModel
            {
                EmployeeID = 108,
                EmployeeName = "Ganesh",
                BasicPay = 450000,
                start_date = new DateTime(2016, 07, 04),
                gendre = 'M',
                PhoneNumber = "3216549870",
                Address = "ambajogai",
                Department = "Finance",
                Deduction = 6600.00,
                TaxablePay = 5500,
                NetPay = 4000,
                Tax = 5000.00,
            };
            bool result = employeePayrollRepo.InsertEmployee(model);
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Given Employee Payroll When Add New Employee Then should Return Expected Result
        /// </summary>
        [TestMethod]
        public void GivenEmployeePayroll_WhenAddNewEmployee_ThenshouldReturnExpectedResult()
        {
            bool expected = true;
            EmployeeRepo employeePayrollRepo = new EmployeeRepo();
            EmployeeModel model = new EmployeeModel
            {
                EmployeeID = 109,
                EmployeeName = "Rushi",
                BasicPay = 510000,
                start_date = new DateTime(2016, 08, 12),
                gendre = 'M',
                PhoneNumber = "3216549870",
                Address = "Latur",
                Department = "Finance",
                Deduction = 6600.00,
                TaxablePay = 5500,
                NetPay = 4000,
                Tax = 5000.00,
            };
            bool result = employeePayrollRepo.addEmployeeToPayroll(model);
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// UC_10 GivenEmployee_PayrollServiceDb add new record in DB.
        /// </summary>
        [TestMethod]
        public void GivenEmployee_PayrollServiceDb_AddNewEmployee()
        {
            bool expected = true;
            EmployeeRepo employeePayrollRepo = new EmployeeRepo();
            EmployeeModel model = new EmployeeModel
            {
                EmployeeID = 110,
                EmployeeName = "Rahul",
                BasicPay = 450000,
                start_date = new DateTime(2016, 07, 04),
                gendre = 'M',
                PhoneNumber = "3216549870",
                Address = "ambajogai",
                Department = "Finance",
                Deduction = 6600.00,
                TaxablePay = 5500,
                NetPay = 4000,
                Tax = 5000.00,
            };
            bool result = employeePayrollRepo.addEmployeeToPayroll(model);
            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// UC10 Given Query When Insert Then should Perform Retrival Operation.
        /// </summary>
        [TestMethod]
        public void GivenQuery_WhenInsert_ThenshouldPerformRetrivalOperation()
        {
            int expected = 10;
            EmployeeRepo employeeRepo = new EmployeeRepo();
            int count = employeeRepo.GetAllRecords();
            Assert.AreEqual(expected, count);
        }

        /// <summary>
        /// UC10 Given Query When Insert Then should Perform Update Operation.
        /// </summary>
        [TestMethod]
        public void GivenQuery_WhenInsert_ThenshouldPerformUpdateOperation()
        {
            int expected = 3000000;
            EmployeeRepo empRepo = new EmployeeRepo();
            double count = empRepo.UpdateEmployee();
            Assert.AreEqual(expected, count);
        }

        /// <summary>
        /// UC10 Given Query When Insert Then should Perform get Employee Data With Given Rang.
        /// </summary>
        [TestMethod]
        public void GivenQuery_WhenInsert_ThenshouldPerformgetEmployeeDataWithGivenRange()
        {
            int expected = 10;
            EmployeeRepo empRepo = new EmployeeRepo();
            int count = empRepo.getEmployeeDataWithGivenRange();
            Assert.AreEqual(expected, count);
        }
    }
}




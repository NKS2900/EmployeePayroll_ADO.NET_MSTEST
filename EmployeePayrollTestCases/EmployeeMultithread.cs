using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeePayroll_ADO.NET_MSTEST;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeePayrollTestCases
{
    [TestClass]
    public class EmployeeMultithread
    {
        /// <summary>
        /// UC_1_Payroll_AddMultiple_Employee
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            List<EmployeeModel> modelList = new List<EmployeeModel>();
            modelList.Add(new EmployeeModel() { EmployeeID = 1, EmployeeName = "Nijam", BasicPay = 500000, start_date = new DateTime(2019, 01, 01), gendre = 'M', PhoneNumber = "1245789630", Department = "IT", Address = "Beed", Deduction = 3000, TaxablePay = 2500, NetPay = 40000, Tax = 440 });
            modelList.Add(new EmployeeModel() { EmployeeID = 2, EmployeeName = "Imran", BasicPay = 300000, start_date = new DateTime(2018, 01, 01), gendre = 'M', PhoneNumber = "1245789630", Department = "DS", Address = "Pune", Deduction = 3000, TaxablePay = 2500, NetPay = 40600, Tax = 450 });
            modelList.Add(new EmployeeModel() { EmployeeID = 4, EmployeeName = "Dipak", BasicPay = 900000, start_date = new DateTime(2017, 01, 01), gendre = 'M', PhoneNumber = "1245789630", Department = "IT", Address = "Latur", Deduction = 3000, TaxablePay = 2500, NetPay = 40500, Tax = 460 });
            modelList.Add(new EmployeeModel() { EmployeeID = 3, EmployeeName = "Mahesh", BasicPay = 700000, start_date = new DateTime(2016, 01, 01), gendre = 'F', PhoneNumber = "1245789630", Department = "HR", Address = "Parli", Deduction = 3000, TaxablePay = 2500, NetPay = 40500, Tax = 540 });
            modelList.Add(new EmployeeModel() { EmployeeID = 5, EmployeeName = "Ganesh", BasicPay = 100000, start_date = new DateTime(2015, 01, 01), gendre = 'M', PhoneNumber = "1245789630", Department = "FI", Address = "Latur", Deduction = 3000, TaxablePay = 2500, NetPay = 40500, Tax = 560 });
            modelList.Add(new EmployeeModel() { EmployeeID = 8, EmployeeName = "Asif", BasicPay = 300000, start_date = new DateTime(2014, 01, 01), gendre = 'M', PhoneNumber = "1245789630", Department = "CA", Address = "Pune", Deduction = 3000, TaxablePay = 2500, NetPay = 40500, Tax = 540 });
            modelList.Add(new EmployeeModel() { EmployeeID = 7, EmployeeName = "Vikas", BasicPay = 450000, start_date = new DateTime(2015, 01, 01), gendre = 'M', PhoneNumber = "1245789630", Department = "IT", Address = "Beed", Deduction = 3000, TaxablePay = 2500, NetPay = 40500, Tax = 430 });
            modelList.Add(new EmployeeModel() { EmployeeID = 9, EmployeeName = "Pravin", BasicPay = 655000, start_date = new DateTime(2018, 01, 01), gendre = 'F', PhoneNumber = "1245789630", Department = "DS", Address = "Latur", Deduction = 3000, TaxablePay = 2500, NetPay = 40500, Tax = 550 });
            modelList.Add(new EmployeeModel() { EmployeeID = 10, EmployeeName = "Vivek", BasicPay = 360000, start_date = new DateTime(2019, 01, 01), gendre = 'M', PhoneNumber = "1245789630", Department = "HR", Address = "Pune", Deduction = 3000, TaxablePay = 2500, NetPay = 40500, Tax = 590 });
            modelList.Add(new EmployeeModel() { EmployeeID = 11, EmployeeName = "Bunty", BasicPay = 550000, start_date = new DateTime(2017, 01, 01), gendre = 'F', PhoneNumber = "1245789630", Department = "IT", Address = "Beed", Deduction = 3000, TaxablePay = 2500, NetPay = 40500, Tax = 580 });
            modelList.Add(new EmployeeModel() { EmployeeID = 12, EmployeeName = "Ajay", BasicPay = 350000, start_date = new DateTime(2020, 01, 01), gendre = 'F', PhoneNumber = "1245789630", Department = "CA", Address = "Parli", Deduction = 3000, TaxablePay = 2500, NetPay = 40500, Tax = 570 });

            EmployeePayrollOperation employeePayroll = new EmployeePayrollOperation();
            DateTime startTime = DateTime.Now;
            employeePayroll.AddEmployeeToPayroll(modelList);
            DateTime endTime = DateTime.Now;
            Console.WriteLine("Execution_Time_without_Thread : " + (endTime - startTime));
            EmployeeRepo payrollRepo = new EmployeeRepo();
            EmployeeModel employeeModel = new EmployeeModel
            {
                EmployeeID = 14,
                EmployeeName = "Deva",
                BasicPay = 650000,
                start_date = new DateTime(2018, 01, 01),
                gendre = 'M',
                PhoneNumber = "1234567890",
                Department = "JiO",
                Address = "Latur",
                Deduction = 6000,
                TaxablePay = 3500,
                NetPay = 56000,
                Tax = 1200
            };
            DateTime startTimes = DateTime.Now;
            payrollRepo.addEmployeeToPayroll(employeeModel);
            DateTime endTimes = DateTime.Now;
            Console.WriteLine("Execution_Time_without_Thread : " + (endTimes - startTimes));
            //UC2_Using_Thread
            DateTime startTimeWithThread = DateTime.Now;
            employeePayroll.AddEmployeeToPayroll(modelList);
            DateTime endTimeWithThread = DateTime.Now;
            Console.WriteLine("Execution_Time_Using_Thread : " + (startTimeWithThread - endTimeWithThread));
        }

        /// <summary>
        /// Add Employee Details in both emplyee and payroll and caluculate execution time
        /// </summary>
        [TestMethod]
        public void GivenQuery_WhenInsert_ShouldRecordExecutionTime()
        {
            EmployeeRepo payrollRepo = new EmployeeRepo();
            EmployeeModel employeeModel = new EmployeeModel
            {
                EmployeeID = 14,
                EmployeeName = "Pooja",
                BasicPay = 650000,
                start_date = new DateTime(2018, 01, 01),
                gendre = 'F',
                PhoneNumber = "1234567890",
                Department = "HR",
                Address = "Latur",
                Deduction = 6000,
                TaxablePay = 3500,
                NetPay = 56000,
                Tax = 1200
            };
            DateTime startTimes = DateTime.Now;
            payrollRepo.addEmployeeToPayroll(employeeModel);
            DateTime endTimes = DateTime.Now;
            Console.WriteLine("Execution_Time_without_Thread_DB : " + (endTimes - startTimes));
        }

        /// <summary>
        /// Upadate salary in database and calculate execution Time
        /// </summary>
        [TestMethod]
        public void givenListAndDbss_WhenInsertInPayrollTable_ThenCalculateExacutionTimes()
        {

            EmployeePayrollOperation employeePayroll = new EmployeePayrollOperation();
            EmployeeRepo employeePayrollRepo = new EmployeeRepo();
            EmployeeModel employeeModel = new EmployeeModel
            {
                EmployeeName = "Mahesh",
                BasicPay = 777777
            };

            DateTime startTimesForDb = DateTime.Now;
            employeePayrollRepo.updateEmployeeSalary(employeeModel);
            DateTime endTimesForDb = DateTime.Now;
            Console.WriteLine("Execution_Time_For_Updating_Salary_IN_DB : " + (startTimesForDb - endTimesForDb));


        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeePayroll_ADO.NET_MSTEST;
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
            Assert.AreEqual(result,expect);
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
            Assert.AreEqual(result,expect);
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
        public void GivenEmployeeNames_WhenUpdateSalary_ThenReturnExpectedSalary()
        {  
            EmployeeRepo emprepo = new EmployeeRepo();
            int count = emprepo.getEmployeeDataWithGivenRange();
            int expected = 4;
            Assert.AreEqual(expected, count);
        }
    }
}

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
            bool expect = emprepo.EstablishConnection();
            bool result = true;
            Assert.AreEqual(result,expect);
        }

        /// <summary>
        /// Given Employee Payroll Service DB when Retrive then return Count of employee
        /// </summary>
        [TestMethod]
        public void GivenPayrollServiceDB_WhenRetrieve_ThenReturnPayrollServiceFromDataBase()
        {
            EmployeeRepo emprepo = new EmployeeRepo();
            int expect = emprepo.GetAllRecords();
            int result = 7;
            Assert.AreEqual(result,expect);
        }
    }
}

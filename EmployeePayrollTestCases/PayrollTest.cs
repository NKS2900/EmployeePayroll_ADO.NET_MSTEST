using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeePayroll_ADO.NET_MSTEST;
namespace EmployeePayrollTestCases
{
    [TestClass]
    public class PayrollTest
    {
        [TestMethod]
        public void CheckConnection()
        {
           EmployeeRepo emprepo = new EmployeeRepo();
            bool expect = emprepo.EstablishConnection();
            bool result = true;
            Assert.AreEqual(result,expect);
        }
    }
}

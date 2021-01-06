using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayroll_ADO.NET_MSTEST
{
    public class EmployeePayrollOperation
    {
        public List<EmployeeModel> modelList = new List<EmployeeModel>();
        EmployeeRepo payrollRepo = new EmployeeRepo();

        /// <summary>
        /// Adds the employee to payroll.
        /// </summary>
        /// <param name="employeelist">The employeelist.</param>
        public void AddEmployeeToPayroll(List<EmployeeModel> employeelist)
        {
            employeelist.ForEach(employeeData =>
            {
                Console.WriteLine("Employee_Being_added : " + employeeData.EmployeeName);
                this.AddEmployeePayroll(employeeData);
                Console.WriteLine("Employee_added : " + employeeData.EmployeeName);
            });
            Console.WriteLine(this.modelList.ToString());
        }

        /// <summary>
        /// UC_2 Adding Employee and calculating Execution Time Using Thread.
        /// </summary>
        /// <param name="employeelist">The employeelist.</param>
        public void AddEmployee_UsingThread(List<EmployeeModel> employeelist)
        {
            employeelist.ForEach(employeeData =>
            {
                Task thread = new Task(() =>
                {
                    Console.WriteLine("Employee_Being_Added : " + employeeData.EmployeeName);
                    this.AddEmployeePayroll(employeeData);
                    Console.WriteLine("Employee_Added :" + employeeData.EmployeeName);
                });
                thread.Start();
            });
            Console.WriteLine(this.modelList.Count);
        }

        /// <summary>
        /// Adds the employee to payroll.
        /// </summary>
        /// <param name="employeeData">The employee data.</param>
        public void AddEmployeePayroll(EmployeeModel employeeData)
        {
            modelList.Add(employeeData);

        }

    }
}

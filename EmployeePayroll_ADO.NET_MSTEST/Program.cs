using System;

namespace EmployeePayroll_ADO.NET_MSTEST
{
    class Program
    {
        public void show()
        {
            Console.WriteLine("***Welcome_To_Employee_Payroll_Service_MSTEST***");
            EmployeeRepo emprepo = new EmployeeRepo();
            Console.WriteLine(emprepo.EstablishConnection());
            Console.WriteLine(emprepo.GetAllRecords());
            Console.WriteLine(emprepo.UpdateEmployee());
            Console.WriteLine(emprepo.getEmployeeDataWithGivenRange());
            Console.WriteLine(emprepo.getAggrigateSumSalary());
            Console.WriteLine(emprepo.getAvragSalary());
            Console.WriteLine(emprepo.getMinSalary());
            Console.WriteLine(emprepo.getMaxSalary());
            Console.WriteLine(emprepo.getCountSalary());
            Console.WriteLine(emprepo.getCountSalary());
        }
    }
}

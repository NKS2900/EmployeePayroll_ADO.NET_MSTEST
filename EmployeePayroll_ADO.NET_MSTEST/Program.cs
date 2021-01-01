using System;

namespace EmployeePayroll_ADO.NET_MSTEST
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Welcome_To_Employee_Payroll_Service_MSTEST***");
            EmployeeRepo emprepo = new EmployeeRepo();
            Console.WriteLine(emprepo.EstablishConnection());
            Console.WriteLine(emprepo.GetAllRecords());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace EmployeePayroll_ADO.NET_MSTEST
{
    public class EmployeeRepo
    {
        public static string connectString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=payroll_service;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectString);
        
        public bool EstablishConnection()
        {
            try
            {
                using (this.connection)
                {
                    connection.Open();
                    Console.WriteLine("Database_Connected_Successfully....");
                    connection.Close();
                    return true;
                }
            }
            catch
            {
                Console.WriteLine("Database_NOT_Connected!!!");
                return false;
            }
        }
    }
}

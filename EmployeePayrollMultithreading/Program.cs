using NuGet.Protocol.Core.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollMultithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Employee Payroll Problem Using MultiThreading");
            EmpReposiory repository = new EmpReposiory();
            repository.DataBaseConnection(); // database connection using the sql connection string

            Console.ReadLine();
        }
    }

 }

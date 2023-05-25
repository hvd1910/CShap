using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using IO = System.Console;
using Emp = Bank.Accounts.EmployeeDetails;
namespace Bank.Accounts.EmployeeDetails
{
    class AliasExample
    {
        static void Main(string[] args)
        {
            Emp.Employees objEmp = new Emp.Employees();
            objEmp.EmpName = "Peter";

            IO.WriteLine("Employee Name: " +objEmp.EmpName);
        }

    }
}

using System;

namespace Bank.Accounts.EmployeeDetails
{
    public class Employee
    {
        public string EmpName;

        private string _empName;
        private int _empId;

        public Employee() {
            _empName = "David";
            _empId = 101;
        }

        static void Main(string[] args)
        {
            Employee objEmployee = new Employee();
            Employee objEmp =  objEmployee;
            objEmployee = null;

            try
            {
                Console.WriteLine("Employee Name: " + objEmployee._empName);
                Console.WriteLine("Employee ID: " + objEmployee._empId);

            }catch(NullReferenceException objNull)
            {
                Console.WriteLine("Error: " + objNull);

            } catch(Exception objEx) {
                Console.WriteLine("Error: " + objEx);

            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Accounts.EmployeeDetails
{
     class Employee1
    {
        static void ThrowException(string name)
        {
            if( name == null )
            {
                throw new ArgumentNullException();

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Throw Example");
            try
            {
                string empName = null;
                ThrowException(empName);
            }catch(ArgumentNullException objNull)
            {
                Console.WriteLine("Exception caught: " + objNull);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
     class Students
    {
        string[] _names = { "James", "John", "Alexander" };
        static void Main(string[] args)
        {
            Students objStudents = new Students();

            try
            {
                objStudents._names[4] = "Michanel";

            }catch(Exception objException)
            {
                Console.WriteLine("Error: " + objException);
            }
        }
    }
}

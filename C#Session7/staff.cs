using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritDmo1
{
    class staff : People

    {
        protected int salary;

        public void Input1()
        {
            Console.Write("Enter salary: ");
            salary = Convert.ToInt32(Console.ReadLine());
        }
        public void showInput1()
        {
            Console.WriteLine("Salary: {0}", salary);
        }


    }
}

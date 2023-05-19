using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritDmo1
{
    class goldstudent:student
    {
        protected string bonus;

        public void Input4()
        {
            Console.Write("Enter bonus: ");
            bonus = Console.ReadLine();
        }
        public void showInput4()
        {
            Console.WriteLine("Bonus: {0}", bonus);
        }


    }
}

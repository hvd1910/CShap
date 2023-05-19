using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritDmo1
{
     class student:People
    {
        
        protected int GPA;

        public void Input3()
        {
            Console.Write("Enter GPA: ");
            GPA = Convert.ToInt32(Console.ReadLine());
        }
        public void showInput3()
        {
            Console.WriteLine("GPA: {0}", GPA);
        }


    
}
}

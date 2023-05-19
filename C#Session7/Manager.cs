using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritDmo1
{
      class Manager:staff

    {
        protected string level;
       
        public void Input2()
        {
            Console.Write("Enter level: ");
            level = Console.ReadLine();
        }
        public void showInput2()
        {
            Console.WriteLine("Level: {0}", level);
        }

       
    }




}

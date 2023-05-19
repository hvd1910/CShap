using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritDmo1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int x  ;
            Console.Write("1. Manager \n2. Gold Student \nVui lòng chọn chức năng:");
            x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Manager p1 = new Manager();
                    p1.Input();
                    p1.Input1();
                    p1.Input2();
                    Console.WriteLine("____________________________________");
                    p1.showInput();
                    p1.showInput1();
                    p1.showInput2();
                    break;
               case 2:
                    goldstudent gst1 = new goldstudent();
                    gst1.Input();
                    gst1.Input3();
                    gst1.Input4();
                    Console.WriteLine("____________________________________");
                    gst1.showInput();
                    gst1.showInput3();
                    gst1.showInput4();
                    break;
            }


            


           
        }
    }
}

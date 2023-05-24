using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbsEX3
{
    class Staff : Employee {
        

        public override void CaculateBonus()
        {
            double x = (1000 + 0.06) * salary;
            Console.WriteLine("CaculateBonus: " + x);


        }
        public override void CaculateVacation()
        {
            
                if ((Day / 365) > 5)
                {
                    Console.WriteLine("Nghi 4 tuan");

                }
                else
                {
                    Console.WriteLine("Nghi 3 tuan");
                }
            }

        
    }
}

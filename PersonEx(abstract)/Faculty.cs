using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbsEX3
{
     class Faculty : Employee
    {
        
        public override void CaculateBonus()
        {
            double x = (1000 + 0.05) * salary;
            Console.WriteLine("CaculateBonus: " + x);
        }
        public override void CaculateVacation()
        {
            if ((Day / 365) > 3 && (part == "super"))
            {
                Console.WriteLine("Duoc nghi 6 tuan");

            }
            else
            {
                if ((Day / 365) > 3)
                {
                    Console.WriteLine("Nghi 5 tuan");

                }
                else
                {
                    Console.WriteLine("Nghi 4 tuan");
                }
            }
            

            
        }

    }
}

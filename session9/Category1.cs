using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility_Vehicle.Car;
using Utility_Vehicle = Automotive.Vehicle.Jeep;
namespace Automotive
{
    namespace Vehicle
    {
        namespace Jeep
        {
             class Category1
            {
                string _category;

                public Category1()
                {
                    _category = "MultiUtility Vehicle";
                    _category = "MultiUtility Vehicle";
                }

                public void Display()
                {
                    Console.WriteLine("Jeep Category: " + _category);

                }
            }

        }

        class AutoMobile
        {
            static void Main(string[] args)
            {
                Category objCat = new Category();
                objCat.Display();
                Utility_Vehicle.Category1 objCategory1 = new Utility_Vehicle.Category1();
                objCategory1.Display();
            }
        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryExample
{
     class Cylinder
    {
        protected double Radius;
        protected double Height;
        double BaseArea, LateralArea, TotalArea, Volume;

        public Cylinder()
        {
        }

        public Cylinder(double radius, double height)
        {
            this.Radius = radius;
            this.Height = height;
        }

        public void Process()
        {
            Console.WriteLine("Enter dimenstions of the cylinder");
            Console.Write("Radius: ");
            Radius = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            Height = Convert.ToDouble(Console.ReadLine());
            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;

            BaseArea = Math.Round(BaseArea, 2);
            LateralArea = Math.Round(LateralArea, 2);
            TotalArea = Math.Round(TotalArea, 2);
            Volume = Math.Round(Volume, 2);


        }


        public void Result()
        {
            

           
  

            Console.WriteLine("Cylinder Characteristics");
            Console.WriteLine("Radius: " + Radius + "Height: " + Height);
            Console.WriteLine("Base: " + BaseArea + ": Lateral: " + LateralArea + ": Total: " + TotalArea + ": Volume" + Volume);


        }
    }
}

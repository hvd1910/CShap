using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
     class Animal
    {
        protected string name;
        protected double weight;

        public Animal()
        {
        }

        public Animal(string name, double weight)
        {
            this.name = name;
            this.weight = weight;
        }


        public void SetMe(string name, double weight)
        {
            this.name = name;
            this.weight = weight;
        }

        public void Show()
        {
            Console.WriteLine("Name: " + name + ", Weight: " + weight);

        }
    }

    class Lion : Animal
    {
        public Lion() { }
    }
    class Tiger : Animal
    {
        public Tiger() { }
    }
}

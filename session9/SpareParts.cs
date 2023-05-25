using System;

namespace Automotive
{
    public class SpareParts
    {
        string _spareName;
        public SpareParts() {
            _spareName = "Gear Box";
        }


        public void Display()
        {
            Console.WriteLine("Spare Part Name: " + _spareName);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotive
{
     class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "John", "James" };
            int numOne = 0;
            int result;
            try
            {
                Console.WriteLine("This is the outer try block");
                try
                {
                    result = 133 / numOne;
                }catch (ArithmeticException objMaths)
                {
                    Console.WriteLine("Divide by 0" + objMaths);
                }
                names[2] = "Smith";
            }
            catch (IndexOutOfRangeException objIndex)
            {
                Console.WriteLine("Wrong number of arguments supplied" + objIndex);
            }
        }

        static void Main(object[] args)
        {
            string[] names = { "John", "James" };
            int numOne = 10;
            int result = 0 ;
            int index = 0;
            try
            {
                index = 3;
                names[index] = "Smith";
                result = 130 / numOne;
            }catch(DivideByZeroException objDivide) {
                Console.WriteLine("Divide by 0" + objDivide);
            }catch (IndexOutOfRangeException objIndex)
            {
                Console.WriteLine("Wrong number of argument supplied" + objIndex);
            }
            catch(Exception objException)
            {
                Console.WriteLine("Error: " + objException);
            }
            Console.WriteLine(result);
        
    }
}

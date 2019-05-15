using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            // Working With Numbers

            int num = 6;

            Console.WriteLine(5 + 8);
            Console.WriteLine(5 - 8);
            Console.WriteLine(5 / 8);
            Console.WriteLine(5 * 8);
            Console.WriteLine(5 % 2);
            
            Console.WriteLine((4 + 2) * 3);
            Console.WriteLine(5.0 + 8.1);
            Console.WriteLine(5 + 8.1);
            Console.WriteLine(5 / 2.0);

            Console.WriteLine(num);
            num++;
            Console.WriteLine(num);
            num--;
            Console.WriteLine(num);
            
            // Math Methods
            Console.WriteLine(Math.Abs(-40)); // Absolute Value
            Console.WriteLine(Math.Pow(3, 2)); // Power 3 to the 2 power
            Console.WriteLine(Math.Sqrt(36)); // Square root
            Console.WriteLine(Math.Max(4, 90)); // bigest number
            Console.WriteLine(Math.Min(4, 90)); // Smaller number
            Console.WriteLine(Math.Round(22.3)); // Round number


            Console.ReadLine();
        }
    }
}

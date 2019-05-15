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
            // Getting User Input
            Console.Write("Enter your name: "); // Prints in the same line
            string name = Console.ReadLine(); // Store the input to the variable name
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " you are " + age + " years old");


            // Keep the console open
            Console.ReadLine();
        }
    }
}

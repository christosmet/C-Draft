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
            // Working With Strings
            string phrase = "Giraffe Academy";

            Console.WriteLine("Giraffe\nAcademy");

            Console.WriteLine("\"Giraffe\"Academy");

            Console.WriteLine(phrase);

            Console.WriteLine("Giraffe Academy" + " is cool");

            Console.WriteLine(phrase.Length);

            // string Methods

            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.ToLower());
            Console.WriteLine(phrase.Contains("Academy")); //returns true false
            Console.WriteLine(phrase[2]);
            Console.WriteLine(phrase.IndexOf("Academy")); //Where it starts index
            Console.WriteLine(phrase.Substring(8, 3)); // prints from the index and after


            Console.ReadLine();
        }
    }
}

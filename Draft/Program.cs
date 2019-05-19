using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft
{
    class Program
    {
        static void Main(string[] args)
        {
            // Getters & Setters
            Movie avengers = new Movie("The Avengers", "Joss Whedon", "Dog");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");

            Console.WriteLine(avengers.Rating);

            // keep open the console window
            Console.ReadLine();
        }
    }
}

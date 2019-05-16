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
            // Methods
            // Call A Method
            SayHi("Christos", 33);
            SayHi("Tom", 12);
            // keep open the console window
            Console.ReadLine();
        }

        // Method Structure
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + " you are " + age + " years old");
        }
    }
}

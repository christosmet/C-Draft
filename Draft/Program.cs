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
            // Arrays
            int[] luckyNumbers = {4, 8, 15, 16, 23, 42};
            string[] friends = new string[5]; //new string[number of values]

            // Change a value
            luckyNumbers[1] = 900;
            friends[0] = "Christos";
            friends[1] = "Jim";
            friends[2] = "Kelly";
            friends[3] = "Manolis";
            friends[4] = "Kostas";


            Console.WriteLine(luckyNumbers[1]);
            Console.WriteLine(friends[4]);

            // keep open the console window
            Console.ReadLine();
        }
    }
}

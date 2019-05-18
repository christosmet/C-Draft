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
            // For Loops
            int[] luckyNumbers = {4, 8, 15, 16, 23, 42};
            for(int i = 0; i < luckyNumbers.Length; i++)
            {
                
                Console.WriteLine(luckyNumbers[i]);
            }


            // keep open the console window
            Console.ReadLine();
        }
    }
}

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
            // 2d Arrays
            int[,] numberGrid = {{1, 2}, {3, 4}, {5, 6}}; 
            
            // if array values are unknown
            int[,] myArray = new int[2, 3]; // ex. has 2 elements and each of this have 3 elements inside



            Console.WriteLine(numberGrid[0, 0]);

            // keep open the console window
            Console.ReadLine();
        }
    }
}

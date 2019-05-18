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
            // While Loops

            int index = 6;
            while(index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }

            do 
            {
                Console.WriteLine(index);
                index++;
            } while(index <= 5);


            // keep open the console window
            Console.ReadLine();
        }
    }
}

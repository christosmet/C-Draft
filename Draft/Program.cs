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
            // If Statements
            bool isMale = false;
            bool isTall = true;
            
            if(isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            } else  if(isMale && !isTall) 
            {
                Console.WriteLine("You are a short male");
            } else  if(!isMale && isTall) 
            {
                Console.WriteLine("You are not male but you are tall");
            } else
            {
                Console.WriteLine("You are not male and not tall");
            }


            // keep open the console window
            Console.ReadLine();
        }
    }
}

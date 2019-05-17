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
            // More If Statements 
            Console.WriteLine(GetMax(20,10,4));

            // keep open the console window
            Console.ReadLine();
        }

        static int GetMax(int num1, int num2, int num3)
        {
            int result;
            if(num1 >= num2 && num1 > num3)
            {
                result = num1;
            } else if (num2 >= num1 && num2 >= num3) 
            {
                result = num2;
            } else 
            {
                result = num3;
            }   
        }
    }
}

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
            // Exception Handling

            // Add risky code that maybe throw exception message
            try 
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            /*
            catch(Exception e) // Throw an error message and program doesn't terminate
            {
                Console.WriteLine(e.Message);

            }*/
            // can specify a specific type of exception
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(FormatException e) 
            {
                Console.WriteLine(e.Message);
            }
            /* code in finaly will be executed no matter what (optional)
            finally
            {
                
            } */

            // keep open the console window
            Console.ReadLine();
        }
    }
}

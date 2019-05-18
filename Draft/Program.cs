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
            // Building a Guessing Game

            string secretWord = "giraffe";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while(guess != secretWord && !outOfGuesses)
            {
                if(guessCount < guessLimit)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessCount++;    
                }
                else 
                {
                    outOfGuesses = true;
                }
                
            }
            if(outOfGuesses)
            {
                Console.WriteLine("You Lose!");
            } 
            else 
            {
                Console.WriteLine("You Win!");
            } 
            
            
            // keep open the console window
            Console.ReadLine();
        }
    }
}

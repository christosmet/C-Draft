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
            // Constructors

            Book book1 = new Book("Harry Potter", "JK Rowling", 400);

            Book book2 = new Book("Lord Of the Rings", "Tolkein", 700);
            Book book3 = new Book();
            book2.title = "The hobbit";

            Console.WriteLine(book2.title);

            // keep open the console window
            Console.ReadLine();
        }
    }
}

﻿using System;
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
            // Classes & Objects
            // Create a Book
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Book book2 = new Book();
            book2.title = "Lord Of the Rings";
            book2.author = "Tolkein";
            book2.pages = 700;

            Console.WriteLine(book2.author);

            // keep open the console window
            Console.ReadLine();
        }
    }
}

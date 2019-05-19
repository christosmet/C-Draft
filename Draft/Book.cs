using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        // Contructor

        // Can create 2 constructors
        public Book()
        {
            
        }
        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }
    }
}

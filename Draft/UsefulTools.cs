using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft
{
    static class UsefulTools // If we add the static keyword in the class then we can't create an instance of this class
    {
        // Static Method can be accessed without to create an instance of this class
        public static void SayHi(string name)
        {
            Console.WriteLine("Hello " + name);
        }
    }
}

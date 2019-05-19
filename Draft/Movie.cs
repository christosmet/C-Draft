using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft
{
    class Movie
    {
        public string title;
        public string director;
        private string rating; // private can be accessed only by the Movie Class

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating; // SET the value by calling the setter method
        }

        public string Rating
        {
            get { return rating; }
            set 
            {
                if(value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else 
                {
                    rating = "NR";
                }
            }
        }


    }
}

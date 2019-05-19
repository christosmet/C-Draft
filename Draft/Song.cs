using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft
{
    class Song
    {
        public string title;
        public string artist;
        public int duration;
        // Static variable the same for all objects that will be created from this class
        public static int songCount = 0;

        public Song(string aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            // Every time a Song Object creates increment song Count by 1
            songCount++;
        }

        public int getSongCount()
        {
            return songCount;
        }
    }
}

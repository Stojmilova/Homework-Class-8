using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    
    public class Song
    {
        public string Title { get; set; }
        public double Length { get; set; }
        public Genre SongType { get; set; }

        public Song(string title, double length, Genre value)
        {
            Title = title;
            Length = length;
            SongType = value;
        }
        public Song()
        {
                
        }
        public enum Genre
        {
            Rock,
            Hip_Hop,
            Techno,
            Classical
        }

    }
   
}

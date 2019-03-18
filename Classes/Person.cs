using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Song.Genre FavoriteMusicType { get; set; }
        public List<Song> FavouriteSongs { get; set; }

        public Person(int id, string firstName, string lastname, int age, Song.Genre value)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastname;
            Age = age;
            FavoriteMusicType = value;
            FavouriteSongs = new List<Song>();
        }

        public Person()
        {

        }
        public void GetFavSongs()
        {
           Console.WriteLine($"{FirstName} favourite songs are:");
            if(FavouriteSongs.Count != 0)
            {
                foreach (var song in FavouriteSongs)
                {
                    Console.WriteLine($"- {song.Title}");
                    Console.WriteLine("\n");
                }
            }
            else{
                 Console.WriteLine($"{FirstName}: hates music!");
                }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;


namespace Exercise2
{
    class Program
    {

        static void Main(string[] args)
        {
            /* Exercise 2:
               Create a class Song with the following properties: Title, Length and, Genre
               Genre is enum with - Rock, Hip_Hop, Techno and Classical
               Create a class Person with the following properties: Id, FirstName, LastName,
               Age, FavoriteMusicType (Genre enum) and FavoriteSongs.FavoriteSongs is a list of Songs.
               Create a method called GetFavSongs() that will print out all the titles of their
               favorite songs or write a message that this person hates music if there are
               no favorite songs in their list.            
             */

            var ListOfSongs = new List<Song>()
            {
                new Song("NewYork", 2.45, Song.Genre.Rock),
                new Song("I Want It That Way", 1.98, Song.Genre.Classical),
                new Song("Every Breath You Take", 2.15, Song.Genre.Techno),
                new Song("The Final Countdown", 3.07, Song.Genre.Rock),
                new Song("Sweet Child o' Mine", 2.73, Song.Genre.Rock),
                new Song("Enter Sandman", 3.01, Song.Genre.Techno),
                new Song("Rainbow in the Dark", 3.45, Song.Genre.Hip_Hop),
                new Song("Lose Yourself", 2.15, Song.Genre.Classical),
                new Song("Is This Love", 3.17, Song.Genre.Rock),
                new Song("In Your Eyes", 2.87, Song.Genre.Hip_Hop),
                new Song("Can't Get You Out of My Head", 2.65, Song.Genre.Classical),
                new Song("Wake Me Up Before You Go-Go", 3.28, Song.Genre.Hip_Hop),
                new Song("Right Here Waiting", 1.89, Song.Genre.Rock),
                new Song("Mighty to Save", 3, Song.Genre.Techno),
                new Song("Carrie", 2.78, Song.Genre.Rock)
            };
 

            Person person1 = new Person(12345, "Jack", "Connor", 29, Song.Genre.Rock);
            person1.FavouriteSongs.Add(ListOfSongs[0]);
            person1.FavouriteSongs.Add(ListOfSongs[3]);
            person1.FavouriteSongs.Add(ListOfSongs[8]);

            person1.GetFavSongs();

            Person person2 = new Person(23456, "Harry", "Reece", 29, Song.Genre.Classical);
            person2.FavouriteSongs.Add(ListOfSongs[5]);
            person2.FavouriteSongs.Add(ListOfSongs[1]);
         

            person2.GetFavSongs(); 

            Person person3 = new Person(34567, "Jacob", "Callum", 29, Song.Genre.Rock);

            person3.GetFavSongs();


            Person person4 = new Person(45678, "William", "Rhys", 29, Song.Genre.Hip_Hop);
            person4.FavouriteSongs.Add(ListOfSongs[13]);
            person4.FavouriteSongs.Add(ListOfSongs[9]);
            person4.FavouriteSongs.Add(ListOfSongs[4]);
            person4.FavouriteSongs.Add(ListOfSongs[11]);
            person4.FavouriteSongs.Add(ListOfSongs[2]);

            person4.GetFavSongs();


            Person person5 = new Person(56789, "James", "Joe", 29, Song.Genre.Techno);
            person5.FavouriteSongs.Add(ListOfSongs[7]);

            person5.GetFavSongs();

            Console.ReadLine();

        }
    }
}

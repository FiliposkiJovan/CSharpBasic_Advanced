using Class8Excercies2.Entities;
using Class8Excercies2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Class8Excercies2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Song> songList = new List<Song>() {
                new Song("Master Of Puppets", 3, Genre.Rock),
                new Song("Nothing else metter", 5, Genre.Rock),
                new Song("Still dr.dre", 3, Genre.Hip_Hop),
                new Song("Traffic", 4, Genre.Techno)
            };

            List<string> songsList = songList.Where(song => song.Genre == Genre.Rock)
                                             .Select(song => song.Title)
                                             .ToList();

            Person person = new Person(1, "Jovan", "Filiposki", 24, Genre.Rock,
                new List<Song>()
                {
                    new Song("Master Of Puppets", 3, Genre.Rock)
                }) ;

            person.GetFaveSongs();
        }
    }
}

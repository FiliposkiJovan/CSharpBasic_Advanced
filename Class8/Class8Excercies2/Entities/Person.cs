using Class8Excercies2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Class8Excercies2.Entities
{
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Song> FavoriteSong { get; set; }
        public Genre FavoriteMusicType { get; set; }

        public Person(int id, string firstName, string lastName, int age, Genre favoriteMusicType, List<Song> favoriteSong)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            FavoriteSong = favoriteSong;
            FavoriteMusicType = favoriteMusicType;
        }

        public void GetFaveSongs()
        {
            if (FavoriteSong.Any())
            {
                FavoriteSong.ForEach(x => Console.WriteLine(x.Title));
            }
            else
            {
                Console.WriteLine($"{FirstName} {LastName} is boring person");
            }
        }
    }
}

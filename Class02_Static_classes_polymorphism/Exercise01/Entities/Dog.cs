using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.Entities
{
    public class Dog
    {
        public const int MIN_ID_VALUE = 0;
        public const int MIN_NAME_LENGHT = 2;
        public const string COLOR_CHECK = null;

        public int Id { get; set; }
        public string Name { get; set; }  
        public string Color { get; set; }

        public Dog(int id, string name, string color)
        {
            Id = id;
            Name = name;
            Color = color;
        }

        public void Bark()
        {
            Console.WriteLine("Bark Bark");
        }

        public static void Validate(Dog dog)
        {
            if (dog.Id < MIN_ID_VALUE)
            {
                Console.WriteLine("Id is less than 0");
            }
            else if (dog.Name.Length < MIN_NAME_LENGHT)
            {
                Console.WriteLine("Name have less then 2 characters");
            }
            else if (dog.Color != COLOR_CHECK)
            {
                Console.WriteLine($"Dog is {dog.Color}");
            }
        }
    }
}

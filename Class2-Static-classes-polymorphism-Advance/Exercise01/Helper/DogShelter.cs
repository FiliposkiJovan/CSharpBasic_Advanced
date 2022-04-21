using Exercise01.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.Helper
{
    public static class DogShelter
    {
        public static List<Dog> DOGS = new List<Dog>()
        {
            new Dog(1,"GoldenDoodle","Apricot"),
            new Dog(2,"Beagle","Brown"),
            new Dog(3,"Dobermane","Black")
        };

        public static void PrintAll()
        {
            foreach (Dog d in DOGS)
            {
                Console.WriteLine(d);
            }

        }
    }
}

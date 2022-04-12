using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass.Entities
{
    public class Owl : Bird
    {
        public Owl(string color, int flightSpeed, int height) : base(color, flightSpeed, height)
        {
        }

        public override void Sing()
        {
            Console.WriteLine("Owl is singing the owl song!");
        }
    }
}

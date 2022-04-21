using Class9.Entities;
using Class9.Enums;
using System;
using System.Collections.Generic;
using Class9.Exeptions;

namespace Class9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string[] array = new string[] { "1", "2", "3" };

            int integer;

            try
            {
                //Console.WriteLine(array[3]);
                //Console.WriteLine(array[2]);
                integer = int.Parse(Console.ReadLine());
                //throw new ExecutionEngineException("An Exeption is thrown");
            }

            catch (Exception exeption)
            {
                //Console.WriteLine($"An error occured during the access of the array. \n {exeption.Message");
                Console.WriteLine("The input was not a number");
                Console.WriteLine("Setting default value to integer to 5");
                integer = 5;
            }

            finally
            {
                //Console.WriteLine("Finnaly block executed");
                Console.WriteLine($"The number is {integer}");
            }*/
            try
            {
                Cinema cineplexx = new Cinema("Cineplessm", new List<string>() { "Hall 7", "Hall 3", "Hall 4" },
                                         new List<Movie>() {new Movie ("Batman", Genre.Action, 7),
                                                            new Movie ("Lost City", Genre.Action, 10),
                                                            new Movie ("Morbius", Genre.Comedy, 0) });
            }
            catch (InvalidRatingExeption exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}

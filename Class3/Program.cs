using System;

namespace Class3
{
    class Program
    {
        static void Main(string[] args)
        {
            // working with TryParse 
            /*Console.WriteLine("Enter a number(integer)");

            string number = Console.ReadLine();

            //int parsedNumberError = int.Parse(number);

            bool isParsed = int.TryParse(number, out int parsedNumber);

            if (!isParsed)
            {
                Console.WriteLine($"The provided input {number} is not a nubmer");
            }
            else
            {
                Console.WriteLine($"The input is a number! {parsedNumber}");
            }*/


            /*//loops (for,while)
            //fore
            for (int counter=0; counter<6; counter++)
            {
                Console.WriteLine(counter);
            }

            //while 
            int counterWhile = 0;
            while(counterWhile != 6)
            {
                Console.WriteLine(counterWhile);

                counterWhile++;
            }*/

            //do while
            /*int counterDoWhile = 6;
            do
            {
                Console.WriteLine(counterDoWhile);
                counterDoWhile--;
            }
            while (counterDoWhile>0);*/

            /*//break
            for (int counter = 6; counter > 0; counter--)
            {
                if (counter == 3)
                {
                    break;
                }
                Console.WriteLine(counter);
            }*/

            /*//continue
            for (int counter = 6; counter > 0; counter--)
            {
                if (counter == 3)
                {
                    continue;
                }
                Console.WriteLine(counter);
            }*/

            //exercise 1
            /*Console.WriteLine("Enter a number(integer)");
            string number = Console.ReadLine();

            int broj;
            bool isNumberParse = int.TryParse(number, out broj);

            if (isNumberParse)
            {
                for (int i = 1; i <= broj; i++)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("Enter a number(integer)");
            string number2 = Console.ReadLine();

            int broj2 = int.Parse(number2);

            for(int i=broj2; i >= 1;i--)
            {
                Console.WriteLine(i);
            }*/

            //exercise
            /*string num1 = Console.ReadLine();

            bool isNumOneParsed = int.TryParse(num1, out int numberOneParsed);

            if (isNumOneParsed)
            {
                *//*for (int counter =2; counter<= numberOneParsed; counter++)
                {
                    if(counter % 2 == 0)
                    {
                        Console.WriteLine(counter);
                    }
                }*//*

                //Optimal way to run this code
                for (int counter = 2; counter <= numberOneParsed; counter += 2)
                {
                    Console.WriteLine(counter);
                }
            }

            string num2 = Console.ReadLine();

            bool isNumTwoParsed = int.TryParse(num2, out int numberTwoParsed);

            if (isNumTwoParsed)
            {
                for(int counter = 1; counter <= numberTwoParsed; counter += 2)
                {
                    Console.WriteLine(counter);
                }
            }*/

            /*//exercise ss
            string input = Console.ReadLine();

            bool isNumberParsed = int.TryParse(input, out int parsedNumber);

            if (isNumberParsed)
            {

            }*/






            //ARRAYS 
            string[] workDaysOfWeek = { "Monday", "Thuesday", "Wednesday", "Thursday", "Friday", };

            foreach(string day in workDaysOfWeek)
            {
                Console.WriteLine(day);
            }
        }
    }
}

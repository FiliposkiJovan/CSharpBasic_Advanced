using System;

namespace Class4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//WriteNumberMessage();
            int number = ReadANumber();
            Console.WriteLine($"The number you have entered is {number}");

            for (int i = 0; i < number; i++)
            {
                if (IsNumberEven(i))
                    Console.WriteLine(i);
            }
        }

        static int ReadANumber()
        {
            Console.WriteLine("Enter a number");
            string number = Console.ReadLine();
            int.TryParse(number, out int parsedNumber);

            return parsedNumber;
        }

        static void WriteNumberMessage()
        {
            Console.WriteLine("Please enter number");
        }

        static bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
                return true;
            else
                return false;
        }*/
            Console.WriteLine("Enter a 2 numbers");
            string number = Console.ReadLine();
            string number2 = Console.ReadLine();
            int.TryParse(number, out int parsedNumber);
            int.TryParse(number2, out int parsedNumber2);
            int sum = Sum(parsedNumber, parsedNumber2);
            Console.WriteLine($"Sum is: {sum}");
            int sub = Substract(parsedNumber, parsedNumber2);
            Console.WriteLine($"Subtraction is: {sub}");

            static int Sum(int a,int b)
            {
                int c = a + b;
                return c;
            }
            static int Substract(int a,int b)
            {
                int c = a - b;
                return c;
            }
        }

    }
}

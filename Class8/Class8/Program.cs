using System;
using System.Collections.Generic;

namespace Class8
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> ageDictionary = new Dictionary<string, int>()
            {
                { "Jovan", 24 },
                { "Bojan", 23 },
                { "Koki", 25 }

            };
            ageDictionary.Add("Petko", 20);
            ageDictionary.Add("Stanko", 25);
            ageDictionary["Petko"] = 30;

            if (ageDictionary.ContainsKey("asdf"))
            {
                int age = ageDictionary["asdf"];
            }

            ageDictionary.Remove("Petko");

            int dictioneryCount = ageDictionary.Count;

            //Console.WriteLine($"The age of Petko is: {ageDictionary["Petko"]}");
            Console.WriteLine($"{ageDictionary["Jovan"]}");



            List<int> intList = new List<int>() { 1, 2, 3, 4 };
            intList.Add(5);
            Console.WriteLine(intList[0]);

            intList.AddRange(new List<int> { 6, 7, 8 });

            List<string> stringList = new List<string>();

            Console.WriteLine($"First occurance of 4 is {intList.IndexOf(4)}");

            intList.Insert(intList.Count, 10);



            Queue<DateTime> dateTimeQueue = new Queue<DateTime>();

            dateTimeQueue.Enqueue(DateTime.Now);
            dateTimeQueue.Enqueue(DateTime.Now.AddDays(-1));
            dateTimeQueue.Enqueue(DateTime.Now.AddDays(-2));
            //dateTimeQueue.Enqueue(DateTime.Now.AddDays(-3));

            /*Console.WriteLine(dateTimeQueue.Dequeue());
            Console.WriteLine(dateTimeQueue.Dequeue());*/

            //bool isSuccesfull = dateTimeQueue.TryDequeue(out DateTime lastDate);

            DateTime copyDate = dateTimeQueue.Peek();




            Stack<double> doubleStack = new Stack<double>();
            doubleStack.Push(3.4);
            doubleStack.Push(1.5);
            doubleStack.Push(0.7);
            doubleStack.Push(6.4);

            Console.WriteLine(doubleStack.Pop());
            bool isPoped = doubleStack.TryPop(out double value);

            bool hasElement = doubleStack.TryPeek(out double peekedValue);

        }
    }
}
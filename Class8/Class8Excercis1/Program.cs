using System;
using System.Collections.Generic;

namespace Class8Excercis1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> phoneDictionery = new Dictionary<string, int>()
            {
                {"Jovan", 078505555 },
                {"Miki", 070221443},
                {"Stanko", 071123415 },
                {"Petko", 123456789},
                {"Igor", 072222555}

            };

            string name = Console.ReadLine();
            bool checkName = phoneDictionery.TryGetValue(name, out int value);
            if (phoneDictionery.ContainsKey(name))
            {
                Console.WriteLine($"Number is {phoneDictionery[name]}");
            }
 

        }
    }
}

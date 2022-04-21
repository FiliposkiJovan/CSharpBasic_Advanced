using Excercises2.Entities;
using System;
using System.Collections.Generic;

namespace Excercises2
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Users> users = new List<Users>() {new Admin("admin", "admin"),
                                                   new Admin("root", "password"),
                                                   new Student("jovan", "filiposki",new Subject ("C# Basic"),new List<int> {6, 7, 6, 10}),
                                                   new Trainer("miki", "ivan")};

            string loguser = Console.ReadLine();
            string logpass = Console.ReadLine();

            Users user = null;

            for( int i = 0; i<users.Count; i++)
            {
                 
                if(users[i].Username == loguser && users[i].Password == logpass)
                {
                    user = users[i];
                }
                if()
            }
            
        }
    }
}

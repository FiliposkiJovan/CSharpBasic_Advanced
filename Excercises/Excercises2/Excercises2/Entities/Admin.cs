using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Excercises2.Entities
{
    public class Admin : Users
    {
        public Admin(string username, string password) : base(username, password)
        {

        }
        
        public void RemoveUser(List<Users> users)
        {
            users.ForEach(x=>Console.WriteLine(x.Username));

            string deleteUser = Console.ReadLine();

            users.First(x => x.Username == deleteUser);

            Users userToDelete = users.First(x => x.Username == deleteUser);

            if(userToDelete.Username != Username)
            {
                users.Remove(userToDelete);
            }
            else
            {
                Console.WriteLine("The user you want to delete is userself");
            }
        }

        public void AddUser(List<Users> users)
        {


        }
        
        public void AddStudent(List<Users> users)
        {
            string addUsername = Console.ReadLine();
            string addPassword = Console.ReadLine();

           
        }
    }
}

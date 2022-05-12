using TaxiManager9000.DataAccess.Interface;
using TaxiManager9000.Domain.Entities;
using TaxiManager9000.Domain.Enums;
using TaxiManager9000.Domain.Exceptions;
using TaxiManager9000.Services.Services.Interfaces;
using TaxiManager9000.Shared;

namespace TaxiManager9000.Services
{
    public class AdminService : IAdminService
    {
        private readonly IUserDatabase _database;

        public AdminService()
        {
            _database = DepencyResolver.GetService<IUserDatabase>();
        }

        public void CreateUser(string username, string password, Role role)
        {

            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentNullException("Username is empty");
            }

            if (username.Length <= 5)
            {

                throw new ArgumentNullException("Username is shorter then 5 characters");
            } 

            if (password.Length <= 5)
            {
                throw new ArgumentNullException("Password is shorter then 5 characters");
            }

            User user = new User(username, password, role);

            User currentUser = _database.GetByUserNameAndPassword(username, password);

            if (currentUser != null)
            {
                throw new Exception("User already exists");
            }

            _database.Insert(user);
        }

        public void TerminateUser(string username)
        {
            User existingUser = _database.GetByUserName(username);

            if (existingUser == null)
            {
                throw new NotFoundException("User not found");
            }

            _database.Remove(existingUser);
        }

        public void ChangePassword(string username, string password, string newPassword)
        {
            User existingUser = _database.GetByUserNameAndPassword(username, password);
            
            if(existingUser == null)
            {
                throw new NotFoundException($"The user {username} does not exist");
            }
            existingUser.SetPassword(newPassword);
            _database.Update(existingUser);
        }

        public List<User> ListAllUsers()
        {
            List<User> users = _database.GetAll();

            return users;
        }
    }
}

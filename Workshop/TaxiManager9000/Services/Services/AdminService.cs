using TaxiManager9000.DataAccess.Interface;
using TaxiManager9000.Domain.Entities;
using TaxiManager9000.Shared;

namespace TaxiManager9000.Services.Services.Interfaces
{
    public class AdminService : IAdminService
    {
        private readonly IUserDatabase _database;

        public AdminService()
        {
            _database = DepencyResolver.GetService<IUserDatabase>();
        }

        public void CreateUser(User user)
        {
            if (user == null)
            {
                throw new ArgumentNullException("Username is empty");
            }

            if (user.UserName.Length <= 5)
            {

                throw new ArgumentNullException("Username is shorter then 5 characters");
            } 

            if (user.Password.Length <= 5)
            {
                throw new ArgumentNullException("Password is shorter then 5 characters");
            }

            User currentUser = _database.GetByUserNameAndPassword(user.UserName, user.Password);

            if (currentUser != null)
            {
                throw new Exception("User already exists");
            }

            _database.Insert(user);
        }

        public void TerminateUser(User user)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager9000.Domain.Entities;

namespace TaxiManager9000.DataAccess.Interface
{
    public interface IUserDatabase
    {
        void Insert(User user);

        User GetByUserNameAndPassword(string username, string password);
    }
}

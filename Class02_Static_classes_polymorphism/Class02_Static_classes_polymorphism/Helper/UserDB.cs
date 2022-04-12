using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02_Static_classes_polymorphism.Helper
{
    public static class UserDB
    {
        public const int USERNAME_MAX_LENGHT = 255;

        public static List<User> USERS = new List<User>()
        {
            new User("jovanfiliposki")
        };

    }
}

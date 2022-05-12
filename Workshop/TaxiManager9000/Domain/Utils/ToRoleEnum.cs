using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager9000.Domain.Enums;

namespace TaxiManager9000.Domain.Utils
{
    public static class RoleUtils
    {
        public static Role ToRoleEnum(this string role)
        {
            bool isParseSuccessful = Enum.TryParse(role, out Role roleEnum);

            if (!isParseSuccessful)
            {
                throw new ArgumentException($"{role} is invalid");
            }

            return roleEnum;
        }
    }
}
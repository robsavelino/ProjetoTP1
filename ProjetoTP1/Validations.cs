using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public class Validations
    {
        public static bool ValidateUsername (List<User> users, string username)
        {
            if (users.Find(x => x.Username == user) == null)
                return false;
            return true;
        }
    }
}

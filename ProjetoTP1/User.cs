using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public class User
    {
        public int Id_User { get; set; }
        public string Username { get; set; }
        public string ExibitionName { get; set; }  
        public double Wallet { get; set; }
        public List<User> Friends { get; set; }
        public List<Store> Library { get; set; }

    }
}

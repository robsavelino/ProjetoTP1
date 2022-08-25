using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto;

namespace Projeto
{
    public class User
    {
        public int Id_User { get; set; }
        public string Username { get; set; }
        public string ExibitionName { get; set; }  
        public double Wallet { get; set; }
        public List<string> Friends { get; set; }
        public List<Store> Library { get; set; }

        public User(int id_User, string username, string exibitionName, string wallet)
        {
            Id_User = id_User;
            Username = username;
            ExibitionName = exibitionName;
            Wallet = Convert.ToDouble(wallet);
            Friends = new();
            Library = new();
        }

        public override string ToString()
        {
            return ($"Id| {Id_User}| Username: {Username}| Exibition Name: {ExibitionName}| Wallet: {Wallet}|");
        }
    }
    
}

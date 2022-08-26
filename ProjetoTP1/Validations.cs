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
            if (users.Find(x => x.Username == username) == null)
                return false;
            return true;
        }

        public static bool ValidateHasGame (List<User> users, string username, List<Store> store, string game)
        {
            if (!ValidateUsername(users, username))
            {
                MessageBox.Show("User not found");
                return false;
            }
                
            if(!ValidateGame(store, game))
            {
                MessageBox.Show("Game not found");
                return false;
            }        

            var auxUser = users.Find(x => x.Username == username).Library.ToList();
            var auxGame = store.Find(x => x.GameName == game);

            if (auxUser.Contains(auxGame))
            {
                MessageBox.Show("The user already has this game");
                return false;
            }

            return true;
        }

        public static bool ValidateGame(List<Store> store, string game)
        {
            if (store.Find(x => x.GameName == game) == null)
                return false;
            return true; 
        }

        public static bool ValidatePriceInput (string price)
        {
            return decimal.TryParse(price, out _);
        }

        public static bool ValidateFoundInput (string amount)
        {
            return double.TryParse(amount, out _);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto;

namespace Projeto
{
    public class Services
    {
        public static List<Store> GetLibrary(List<User> users, string username)
        {
            if (!Validations.ValidateUsername(users, username))
            {
                MessageBox.Show("User not found");
                return null;
            }
            return users.Find(x => x.Username == username).Library;
        }
        public static List<string> GetFriendsList(List<User> users, string username)
        {
            if (!Validations.ValidateUsername(users, username))
            {
                MessageBox.Show("User not found");
                return null;
            }
            return users.Find(x => x.Username == username).Friends;
        }
        public static void DeleteFriend(List<User> users, string username, string friend)
        {
            
            if (!Validations.ValidateUsername(users, username))
            {
                MessageBox.Show("User not found");
                return;
            }
            if (!Validations.ValidateUsername(users, friend))
            {
                MessageBox.Show("Friend not found as a user");
                return;
            }
            
            if (users.Find(x => x.Username == username).Friends.Contains(friend) == false)
            {
                MessageBox.Show($"The user {username} doesn't have {friend} as a friend");
                return;
            }
            users.Find(x => x.Username == username).Friends.Remove(friend);
        }
        public static void AddFriend(List<User> users, string username, string friend)
        {
            if (!Validations.ValidateUsername(users, username))
            {
                MessageBox.Show("User not found");
                return;
            }
            if (!Validations.ValidateUsername(users, friend))
            {
                MessageBox.Show("Friend's username is not valid");
                return;
            }
            
            if (users.Find(x => x.Username == username).Friends.Contains(friend) == true)
            {
                MessageBox.Show($"The user {username} already has {friend} as a friend");
                return;
            }

            users.Find(x => x.Username == username).Friends.Add(friend);

        }
        public static List<Store> GamesToBuy (List <User> users, string username, List <Store> store)
        {
            if (!Validations.ValidateUsername(users, username))
            {
                MessageBox.Show("User not found");
                return null;
            }
            var gamesUser = users.Find(x => x.Username == username).Library;
            return store.Where(x => x.Equals(gamesUser) == false).ToList();
        }
        public static List<Store> GamesInCommon(List<User> users, string username, string friend)
        {
            if (!Validations.ValidateUsername(users, username))
            {
                MessageBox.Show("User not found");
                return null;
            }
            if (!Validations.ValidateUsername(users, username))
            {
                MessageBox.Show("Friend not found");
                return null;
            }

            var auxUser = users.Find(x => x.Username == username).Library;
            var auxFriend = users.Find(x => x.Username == friend).Library;

            List<Store> result = new();

            foreach (var item in auxUser)
            {
                foreach (var item2 in auxFriend)
                {
                   if(item == item2)
                        result.Add(item);
                }
            }
            return result;
        }
        public static void AddGame(List<User> users, string username, List<Store> store, string game)
        {
            if (!Validations.ValidateHasGame(users, username, store, game))
                return; 
            
            var auxGame = store.Find(x => x.GameName.ToLower() == game.ToLower());
            users.Find(x => x.Username == username).Library.Add(auxGame);
        }
        public string AddGameToStore(List<Store> store, string gameName, string price, string genre, string publisher)
        {
            if (!Validations.ValidateGame(store ,gameName) && Validations.ValidatePriceInput(price))
            {
                store.Add(new Store(store.Count() + 1, gameName, price, genre, publisher));
                return $"O jogo {gameName} foi adicionado a loja!";
            }

            else if(!Validations.ValidatePriceInput(price))
            {
                return "Por favor, digitar um valor válido no campo Preço";
            }

            return $"O jogo {gameName} já está presente na loja.";
        }
        public void RemoveGameFromStore(string gameName, List<Store> store)
        {
            store.RemoveAll(x => x.GameName == gameName);
        }
        public Store SearchGameByName(List<Store> store, string gameName)
        {
            if (!Validations.ValidateGame(store, gameName))
            {
                MessageBox.Show("Game not found");
                return null;
            }
            var matchGame = store.FirstOrDefault(x => x.GameName ==gameName);
            return matchGame;
        }
        public static void CreateNewUser(List<User> Users, string newUsername, string newExbName)
        {
            if(Validations.ValidateUsername(Users, newUsername))
            {
                MessageBox.Show("User already exists");
                return;
            }
            if (string.IsNullOrWhiteSpace(newUsername))
            {
                MessageBox.Show("Username can't be empty");
                return;
            }
            if (string.IsNullOrWhiteSpace(newExbName))
            {
                MessageBox.Show("Exibition name can't be empty");
                return;
            }

            Users.Add(new User(Users.Count + 1, newUsername, newExbName, "0"));
        }
        public static void AddFounds(List<User> users, string username, string amount)
        {
            if(!Validations.ValidateUsername(users, username))
            {
                MessageBox.Show("User not found");
                return;
            }
            if (!Validations.ValidateFoundInput(amount))
            {
                MessageBox.Show("Found amount is invalid");
                return;
            }
            users.Find(x => x.Username == username).Wallet += Convert.ToDouble(amount);

        }
    }
}

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
                Console.WriteLine("User not found");
                return null;
            }
            return users.Find(x => x.Username == username).Library;
        }
        public static List<User> GetFriendsList(List<User> users, string username)
        {
            if (!Validations.ValidateUsername(users, username))
            {
                Console.WriteLine("User not found");
                return null;
            }
            return users.Find(x => x.Username == username).Friends;
        }
        public static void DeleteFriend(List<User> users, string username, string friend)
        {
            
            if (!Validations.ValidateUsername(users, username))
            {
                Console.WriteLine("User not found");
                return;
            }
            if (!Validations.ValidateUsername(users, friend))
            {
                Console.WriteLine("Friend not found as a user");
                return;
            }

            var auxFriend = users.Find(x => x.Username == friend);
            if (users.Find(x => x.Username == username).Friends.Contains(auxFriend) == false)
            {
                Console.WriteLine($"The user {username} doesn't have {friend} as a friend");
                return;
            }
            users.Find(x => x.Username == username).Friends.Remove(auxFriend);
        }
        public static void AddFriend(List<User> users, string username, string friend)
        {
            if (!Validations.ValidateUsername(users, username))
            {
                Console.WriteLine("User not found");
                return;
            }
            if (!Validations.ValidateUsername(users, friend))
            {
                Console.WriteLine("Friend's username is not valid");
                return;
            }
            var auxFriend = users.Find(x => x.Username == friend);
            if (users.Find(x => x.Username == username).Friends.Contains(auxFriend) == true)
            {
                Console.WriteLine($"The user {username} already has {friend} as a friend");
                return;
            }

            users.Find(x => x.Username == username).Friends.Add(auxFriend);

        }
        public static List<Store> GamesToBuy (List <User> users, string username, List <Store> store)
        {
            if (!Validations.ValidateUsername(users, username))
            {
                Console.WriteLine("User not found");
                return null;
            }
            var gamesUser = users.Find(x => x.Username == username).Library;
            return store.Where(x => x.Equals(gamesUser) == false).ToList();
        }
        public List<Store> GamesInCommon(List<User> users, string username, string friend)
        {
            if (!Validations.ValidateUsername(users, username))
            {
                Console.WriteLine("User not found");
                return null;
            }
            if (!Validations.ValidateUsername(users, username))
            {
                Console.WriteLine("Friend not found");
                return null;
            }

            var auxUser = users.Find(x => x.Username == username);
            var auxFriend = users.Find(x => x.Username == friend);

            return auxUser.Library.Where(x => x.Equals(auxFriend.Library)).ToList();
        }

        public void AddGame(List<User> users, string username, List<Store> store, string game)
        {
            if (!Validations.ValidateHasGame(users, username, store, game))
            {
                return; 
            }

            var auxGame = store.Find(x => x.GameName == game);

            users.Find(x => x.Username == username).Library.Add(auxGame);
        }

        public string AddGameToStore(List<Store> store, string gameName, string price, string genre, string publisher)
        {
            if (!Validations.ValidateGame(store ,gameName) && Validations.ValidatePriceInput(price))
            {
                store.Add(new Store(store.Count() + 1, gameName, price, genre, publisher));
                return $"O jogo {gameName} foi adicionado a loja!";
            }

            else if(Validations.ValidatePriceInput(price))
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
            var matchGame = store.FirstOrDefault(x => x.GameName ==gameName);
            return matchGame;//RELEMBRAR TRATAMENTO DO NULL NA QUESTÃO DO FORMS?
        }

    }
}

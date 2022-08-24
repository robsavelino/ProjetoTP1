using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}

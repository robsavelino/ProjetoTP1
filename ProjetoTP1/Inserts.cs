using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto;

namespace Projeto
{
    public class Inserts
    {
        public static void StartStore (List<Store> store)
        {
            AddingGamesToStore(store);
        }
        public static void StartUsers (List<User> users, List<Store> store)
        {

            AddingUsers(users);
            AddingFriends(users);
            AddingLibrary(users, store);
        }

        public static void AddingUsers(List<User> Users)
        {
            Users.Add(new User(1, "lugan.thierry", "Wolve", "500,00"));
            Users.Add(new User(2, "robsavelino", "robs", "1000,50"));
            Users.Add(new User(3, "matheus.alencastro", "Matte", "950,45"));
            Users.Add(new User(4, "neymar.jr", "Menino do Hexa", "9999,99"));
            Users.Add(new User(5, "gabriel.jesus", "Homem Biscoito", "100,00"));
            Users.Add(new User(6, "carlos.henrique", "Casemiro", "50,20"));
            Users.Add(new User(7, "tiago.leifert", "Ex-BBB", "360,30"));
            Users.Add(new User(8, "miraildes.mota", "Formiga", "850,80"));
            Users.Add(new User(9, "larissa.machado", "Anitta", "5200,00"));
            Users.Add(new User(10, "joao.pedro", "Pedroca", "82,75"));
            Users.Add(new User(11, "ana.sofia", "Aninha", "150,00"));
            Users.Add(new User(12, "maria.lurdes", "Lurda", "489,40"));
            Users.Add(new User(13, "beatriz.silva", "Bia", "640,20"));
            Users.Add(new User(14, "jose.santos", "Zeze", "300,00"));
            Users.Add(new User(15, "rafaela.vilasboas", "Rafa", "3500,00"));
        }

        public static void AddingFriends(List<User> Users)
        {

            Users.Find(x => x.Username == "lugan.thierry").Friends.Add("matheus.alencastro");
            Users.Find(x => x.Username == "lugan.thierry").Friends.Add("robsavelino");
            Users.Find(x => x.Username == "lugan.thierry").Friends.Add("neymar.jr");
            Users.Find(x => x.Username == "lugan.thierry").Friends.Add("larissa.machado");
            Users.Find(x => x.Username == "lugan.thierry").Friends.Add("carlos.henrique");
            Users.Find(x => x.Username == "lugan.thierry").Friends.Add("maria.lurdes");
            Users.Find(x => x.Username == "robsavelino").Friends.Add("matheus.alencastro");
            Users.Find(x => x.Username == "robsavelino").Friends.Add("lugan.thierry");
            Users.Find(x => x.Username == "robsavelino").Friends.Add( "neymar.jr");
            Users.Find(x => x.Username == "robsavelino").Friends.Add("carlos.henrique");
            Users.Find(x => x.Username == "robsavelino").Friends.Add("gabriel.jesus");
            Users.Find(x => x.Username == "matheus.alencastro").Friends.Add("lugan.thierry");
            Users.Find(x => x.Username == "matheus.alencastro").Friends.Add("robsavelino");
            Users.Find(x => x.Username == "matheus.alencastro").Friends.Add("gabriel.jesus");
            Users.Find(x => x.Username == "matheus.alencastro").Friends.Add("carlos.henrique");
            Users.Find(x => x.Username == "matheus.alencastro").Friends.Add("miraildes.mota");
        }

        public static void AddingLibrary (List<User> Users, List<Store> Store)
        {
            Users.Find(x => x.Username == "lugan.thierry").Library.Add(Store.Find(x => x.GameName == "GTA V"));
            Users.Find(x => x.Username == "lugan.thierry").Library.Add(Store.Find(x => x.GameName == "God of War"));
            Users.Find(x => x.Username == "lugan.thierry").Library.Add(Store.Find(x => x.GameName == "Mortal Kombat 11"));
            Users.Find(x => x.Username == "robsavelino").Library.Add(Store.Find(x => x.GameName == "GTA V"));
            Users.Find(x => x.Username == "robsavelino").Library.Add(Store.Find(x => x.GameName == "Stray"));
            Users.Find(x => x.Username == "robsavelino").Library.Add(Store.Find(x => x.GameName == "Counter Strike Global Offensive"));
            Users.Find(x => x.Username == "robsavelino").Library.Add(Store.Find(x => x.GameName == "Bloons TD 6"));
            Users.Find(x => x.Username == "robsavelino").Library.Add(Store.Find(x => x.GameName == "Day Z"));
            Users.Find(x => x.Username == "robsavelino").Library.Add(Store.Find(x => x.GameName == "The Forest"));
            Users.Find(x => x.Username == "matheus.alencastro").Library.Add(Store.Find(x => x.GameName == "Counter Strike Global Offensive"));
            Users.Find(x => x.Username == "matheus.alencastro").Library.Add(Store.Find(x => x.GameName == "F1 2022"));
            Users.Find(x => x.Username == "matheus.alencastro").Library.Add(Store.Find(x => x.GameName == "Fifa 23"));
            Users.Find(x => x.Username == "matheus.alencastro").Library.Add(Store.Find(x => x.GameName == "GTA V"));
            Users.Find(x => x.Username == "matheus.alencastro").Library.Add(Store.Find(x => x.GameName == "Mortal Kombat 11"));

        }
        public static void AddingGamesToStore(List<Store> Store)
        {
            Store.Add(new Store(1, "GTA V", "89,90", "RPG", "Rockstar"));
            Store.Add(new Store(2, "Spider Man Remastered", "249,90", "Action", "Isomniac Games"));
            Store.Add(new Store(3, "Stray", "63,79", "Adventure", "BlueTwelve Studio"));
            Store.Add(new Store(4, "Northgard", "57.99", "Strategy", "Shiro Games"));
            Store.Add(new Store(5, "Digimon Survive", "299,90", "Strategy", "Bandai Namco"));
            Store.Add(new Store(6, "Day Z", "119,99", "Survival", "Bohemia Interactive"));
            Store.Add(new Store(7, "Fifa 23", "299.00", "Sports", "Eletronic Arts"));
            Store.Add(new Store(8, "Euro Truck Simulator 2", "49,99", "Simulator", "SCS Software"));
            Store.Add(new Store(9, "The Forest", "37,99", "Survival", "Endnight Games Ltd"));
            Store.Add(new Store(10, "Among Us", "10,89", "Casual", "Innersloth"));
            Store.Add(new Store(11, "Bloons TD 6", "20,69", "Casual", "Ninja Kiwi"));
            Store.Add(new Store(12, "F1 2022", "249,00", "Racing", "Eletronic Arts"));
            Store.Add(new Store(13, "The Binding of Isaac Rebirth", "27,99", "Indie", "Nicalis Inc"));
            Store.Add(new Store(14, "Hades", "47,99", "Indie", "Supergiant Games"));
            Store.Add(new Store(15, "God of War", "199,90", "Action", "Playstation Pc LLC"));
            Store.Add(new Store(16, "It Takes Two", "199,00", "Adventure", "Eletronic Arts"));
            Store.Add(new Store(17, "Asseto Corsa", "37,99", "Racing", "Kunos Simulazioni"));
            Store.Add(new Store(18, "Garrys Mode", "25,99", "Action", "Valve"));
            Store.Add(new Store(19, "Counter Strike Global Offensive", "71,99", "Action", "Valve"));
            Store.Add(new Store(20, "Mortal Kombat 11", "159,99", "Sports", "Warner Bros.Games"));
        }

    }
}

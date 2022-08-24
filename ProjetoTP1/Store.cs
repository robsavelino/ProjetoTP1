using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto
{
    public class Store
    {
        public int Id_Game { get; set; }
        public string GameName { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }
        public string Publisher { get; set; }

        public Store (int id_Game, string gameName, string price, string genre, string publisher)
        {
            Id_Game = id_Game;
            GameName = gameName;
            Price = Convert.ToDecimal(price);
            Genre = genre;
            Publisher = publisher;
        }
    }
}

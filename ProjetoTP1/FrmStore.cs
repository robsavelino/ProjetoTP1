using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class FrmStore : Form
    {

        public List<Store> Store { get; set; }
        public List<User> Users { get; set; }
        public FrmStore(List<Store> store, List<User> users)
        {
            InitializeComponent();
            this.Store = store;
            this.Users = users;
        }

        private void btnOpenStore_Click(object sender, EventArgs e)
        {
            lsvStoreFull.Items.Clear();
            foreach (var item in Store)
            {
                string[] row = { item.GameName, item.Price.ToString(), item.Genre, item.Publisher };
                var ltsTemp = new ListViewItem(row);
                lsvStoreFull.Items.Add(ltsTemp);
            }
        }

        private void FrmStore_Load(object sender, EventArgs e)
        {

        }

        private void btnSearchGameInStore_Click(object sender, EventArgs e)
        {
            lsvStoreFull.Items.Clear();
            var gameInput = txbGameInput.Text;

            if(!Validations.ValidateGame(Store ,gameInput))
            {
                MessageBox.Show("Game not found.");
                txbGameInput.Clear();
                txbGameInput.Focus();
                return;
            }

            var game = Store.Find(x=> x.GameName == gameInput);
            string[] row = { game.GameName, game.Price.ToString(), game.Genre, game.Publisher };
            var ltsTemp = new ListViewItem(row);
            lsvStoreFull.Items.Add(ltsTemp);
            txbGameInput.Clear();
        }

        private void btnRemoveGameFromStore_Click(object sender, EventArgs e)
        {
            var gameInput = txbGameInput.Text;
            if (!Validations.ValidateGame(Store, gameInput))
            {
                MessageBox.Show("Game not found.");
                txbGameInput.Clear();
                txbGameInput.Focus();
                return;
            }
            var game = Store.Find(x => x.GameName == gameInput);
            Store.Remove(game);
            MessageBox.Show($"The game {game.GameName} was removed from the store.");
            txbGameInput.Clear();
        }

        private void btnAddGameToStore_Click(object sender, EventArgs e)
        {
            var gameName = txbAddGameName.Text;
            var gamePrice = txbAddGamePrice.Text;
            var gameGenre = txbAddGameGenre.Text;
            var gamePublisher = txbAddGamePublisher.Text;
            Services.AddGameToStore(Store, gameName, gamePrice, gameGenre, gamePublisher);

            txbAddGameName.Clear();
            txbAddGamePrice.Clear();
            txbAddGameGenre.Clear();
            txbAddGamePublisher.Clear();
        }
    }
}

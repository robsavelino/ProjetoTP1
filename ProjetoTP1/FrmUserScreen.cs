using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrmProjeto;

namespace Projeto 
{
    public partial class FrmUserScreen : Form
    {
        public List<Store> Store { get; set; }
        public List<User> Users { get; set; }

        public FrmUserScreen(List<User> Users, List<Store> Store)
        {
            InitializeComponent();
            this.Store = Store;
            this.Users = Users;
        }
        private void FrmUserScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGames_Click(object sender, EventArgs e)
        {
            var inputUsername = txbInput.Text.Trim().ToLower();
            listView2.Hide();
            listView1.Show();

            if (!Validations.ValidateUsername(Users, inputUsername))
            {
                MessageBox.Show("Invalid username");
                txbInput.Clear();
                txbInput.Focus();
                return;
            }

            lbl_UserName.Text = inputUsername;
            lbl_ExibitionName.Text = Users.Find(x => x.Username == inputUsername).ExibitionName;
            lbl_Wallet.Text = $"R$ {Users.Find(x => x.Username == inputUsername).Wallet.ToString()}";

            listView1.Items.Clear();
            
            var result = Services.GetLibrary(Users, inputUsername);
            foreach (var item in result)
            {
                string[] row = { item.GameName, item.Genre, item.Publisher };
                var ltvTemp = new ListViewItem(row);
                listView1.Items.Add(ltvTemp);
            }

        }
        private void btnFriends_Click(object sender, EventArgs e)
        {
            var inputUsername = txbInput.Text.Trim().ToLower();
            listView1.Hide();
            listView2.Show();

            if (!Validations.ValidateUsername(Users, inputUsername))
            {
                MessageBox.Show("Invalid username");
                txbInput.Clear();
                txbInput.Focus();
                return;
            }

            lbl_UserName.Text = inputUsername;
            lbl_ExibitionName.Text = Users.Find(x => x.Username == inputUsername).ExibitionName;
            lbl_Wallet.Text = Users.Find(x => x.Username == inputUsername).Wallet.ToString();

            listView2.Items.Clear();
            var result = Services.GetFriendsList(Users, inputUsername);
            
            foreach (var item in result)
            {
                string[] row = { item, Users.Find(x => x.Username == item).ExibitionName };
                var ltvTemp = new ListViewItem(row);
                listView2.Items.Add(ltvTemp);
            }          
        }
        private void btnAddFriend_Click(object sender, EventArgs e)
        {
            var inputUsername = txbInput.Text.Trim().ToLower();
            var inputFriend = txbFriendInput.Text.Trim().ToLower();

            Services.AddFriend(Users, inputUsername, inputFriend);
            txbFriendInput.Clear();
            txbInput.Focus();
        }
        private void btnShowAllUsers_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            listView1.Hide();
            listView2.Show();
            foreach (var item in Users)
            {
                string[] row = { item.Username, item.ExibitionName };
                var ltvTemp = new ListViewItem(row);
                listView2.Items.Add(ltvTemp);
            }
        }
        private void btnCommonGames_Click(object sender, EventArgs e)
        {
            var inputUsername = txbInput.Text.Trim().ToLower();
            var inputFriend = txbFriendInput.Text.Trim().ToLower();

            if(!Validations.ValidateUsername(Users, inputUsername))
            {
                MessageBox.Show("User not found");
                return;
            }
            if (!Validations.ValidateUsername(Users, inputFriend))
            {
                MessageBox.Show("Friend not found");
                return;
            }

            listView2.Hide();
            listView1.Show();
            listView1.Items.Clear();

            var result = Services.GamesInCommon(Users, inputUsername, inputFriend);

            
            if(result.Count == 0)
            {
                MessageBox.Show("No games in common");
                return;
            }

            foreach (var item in result)
            {
                string[] row = { item.GameName, item.Genre, item.Publisher };
                var ltvTemp = new ListViewItem(row);
                listView1.Items.Add(ltvTemp);
            }
        }
        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            var newUsername = txbNewUser.Text.Trim().ToLower();
            var newExbName = txbNewExbName.Text.Trim().ToLower();
            Services.CreateNewUser(Users, newUsername, newExbName);
            txbNewUser.Clear();
            txbNewExbName.Clear();
            txbInput.Focus();
        }
        private void btnAddGameToUser_Click(object sender, EventArgs e)
        {
            var gameName = txbGameName.Text.Trim().ToLower();
            var usernameInput = txbInput.Text.Trim().ToLower();
            Services.AddGame(Users, usernameInput, Store, gameName);
            

            txbGameName.Clear();
            txbGameName.Focus();

        }  
        private void btnAddFounds_Click(object sender, EventArgs e)
        {
            var inputUsername = txbInput.Text.Trim().ToLower();
            var inputAmount = txbAmount.Text.Trim().ToLower().Replace('.', ',');
            
            Services.AddFounds(Users, inputUsername, inputAmount);

            if(Validations.ValidateUsername(Users, inputUsername))
                lbl_Wallet.Text = $"R$ {Users.Find(x => x.Username == inputUsername).Wallet.ToString()}";

            txbAmount.Clear();
            txbAmount.Focus();
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FrmProjectStart();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }
    }
}

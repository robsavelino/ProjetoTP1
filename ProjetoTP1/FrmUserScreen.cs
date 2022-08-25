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
                return;
            }
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
                return;
            }
            listView2.Items.Clear();
            var result = Services.GetFriendsList(Users, inputUsername);
            
            foreach (var item in result)
            {
                string[] row = { item, Users.Find(x => x.Username == item).ExibitionName };
                var ltvTemp = new ListViewItem(row);
                listView2.Items.Add(ltvTemp);
            }          
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoTP1;
using Projeto;

namespace FrmProjeto
{
    public partial class FrmProjectStart : Form
    {
        public List<Store> Store { get; set; }
        public List<User> Users { get; set; }


        public FrmProjectStart()
        {
            InitializeComponent();
        }

        private void FrmProjectStart_Load(object sender, EventArgs e)
        {
            Store = new();
            Inserts.StartStore(Store);
            Users = new();
            Inserts.StartUsers(Users, Store);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FrmMenu();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGoToUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FrmUserScreen(Users, Store);
            form.Show();
        }

        private void btnGoToStore_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FrmStore(Store, Users);
            form.Show();
        }
    }
}

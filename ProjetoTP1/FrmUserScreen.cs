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
        public FrmUserScreen(List<User> Users, List<Store> Store)
        {
            InitializeComponent();
        }

        private void FrmUserScreen_Load(object sender, EventArgs e)
        {

        }

        private void btnGames_Click(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FrmProjectStart();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

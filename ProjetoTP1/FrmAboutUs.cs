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

namespace FrmProjeto.Menu
{
    public partial class FrmAboutUs : Form
    {
        public FrmAboutUs()
        {
            InitializeComponent();
        }

        private void FrmAboutUs_Load(object sender, EventArgs e)
        {
            lbl_PT.Hide();
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
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_PT_Click(object sender, EventArgs e)
        {
            lbl_EN.Hide();
            lbl_PT.Show();
        }

        private void btn_EN_Click(object sender, EventArgs e)
        {
            lbl_PT.Hide();
            lbl_EN.Show();
        }

        private void lbl_EN_Click(object sender, EventArgs e)
        {

        }
    }
}

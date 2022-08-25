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
    }
}

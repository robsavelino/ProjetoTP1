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
        public FrmStore(List<Store> store, List<User> users)
        {
            InitializeComponent();

            //var listViewFullStore = new ListViewItem(store);
            //lsvStoreFull.Items.Add(listViewFullStore);
        }

        private void btnOpenStore_Click(object sender, EventArgs e)
        {

        }
    }
}

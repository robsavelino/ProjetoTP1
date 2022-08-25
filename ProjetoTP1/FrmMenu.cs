using FrmProjeto.Menu;
using FrmProjeto;


namespace ProjetoTP1
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }


        private void btnProgram_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FrmProjectStart();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new FrmAboutUs();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    private void FrmMenu_Load(object sender, EventArgs e)
    {

    }
}
}
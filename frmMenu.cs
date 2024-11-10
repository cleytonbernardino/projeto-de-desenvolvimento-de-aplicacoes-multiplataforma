namespace ProjetoDesenvolvimentoAplicacoesMultplataforma
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            //OpenForm(new frmUsers());
            new frmPessoa(2).Show();
        }

        private void OpenForm(Form frm)
        {
            if (pnlFormContainer.Controls.Count > 0)
            {
                pnlFormContainer.Controls.RemoveAt(0);
            }
            frm.TopLevel = false;
            frm.Dock = DockStyle.Fill;
            pnlFormContainer.Controls.Add(frm);
            pnlFormContainer.Tag = frm;
            frm.Show();
        }

        private void pcbMenuIcon_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width == 250)
            {
                pnlMenu.Width = 50;
            }
            else
            {
                pnlMenu.Width = 250;
            }
        }

        private void pcbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pcbMaximize_Click(object sender, EventArgs e)
        {
            pcbRestore.Visible = true;
            pcbMaximize.Visible = false;
            this.WindowState = FormWindowState.Maximized;
        }

        private void pcbRestore_Click(object sender, EventArgs e)
        {
            pcbRestore.Visible = false;
            pcbMaximize.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void pcbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnVehicleList_Click(object sender, EventArgs e)
        {
            Form frm = new frmVehicles();
            OpenForm(frm);
        }

        private void pcbMain_Click(object sender, EventArgs e)
        {
            if (pnlFormContainer.Controls.Count == 0) return;
            pnlFormContainer.Controls.RemoveAt(0);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Form frm = new frmUsers();
            OpenForm(frm);
        }
    }
}

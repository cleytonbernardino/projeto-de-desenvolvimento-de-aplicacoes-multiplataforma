using System.Runtime.InteropServices;

namespace ProjetoDesenvolvimentoAplicacoesMultplataforma
{
    public partial class frmMenu : Form
    {
        public event EventHandler? ResizedWindow;

        private readonly int _currentUserId;

        public frmMenu(int currentUserId)
        {
            InitializeComponent();
            _currentUserId = currentUserId;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

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
            ResizedWindow?.Invoke(this, EventArgs.Empty);
        }

        private void pcbRestore_Click(object sender, EventArgs e)
        {
            pcbRestore.Visible = false;
            pcbMaximize.Visible = true;
            this.WindowState = FormWindowState.Normal;
            ResizedWindow?.Invoke(this, EventArgs.Empty);
        }

        private void pcbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnVehicleList_Click(object sender, EventArgs e)
        {
            frmVehicles frm = new();
            ResizedWindow += frm.AdjustltvVehicleColumns;
            OpenForm(frm);
        }

        private void pcbMain_Click(object sender, EventArgs e)
        {
            if (pnlFormContainer.Controls.Count == 0) return;
            pnlFormContainer.Controls.RemoveAt(0);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            frmUsers frm = new frmUsers(_currentUserId);
            ResizedWindow += frm.AdjustltvUsersColumns;
            OpenForm(frm);
        }

        private void pnlTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}

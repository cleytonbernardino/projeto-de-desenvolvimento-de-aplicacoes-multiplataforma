using ProjetoDesenvolvimentoAplicacoesMultplataforma.Dao;
using ProjetoDesenvolvimentoAplicacoesMultplataforma.Services;

namespace ProjetoDesenvolvimentoAplicacoesMultplataforma
{
    public partial class frmUsers : Form
    {
        private readonly UserService _service = new();
        private readonly int _currentUserID;

        public frmUsers(int currentUserID)
        {
            InitializeComponent();
            LoadLtvUsers();
            _currentUserID = currentUserID;
        }

        public void AdjustltvUsersColumns(object? sender, EventArgs e)
        {
            chId.Width = (int)Math.Round(0.11 * ltvUsers.Width);
            chFirstName.Width = (int)Math.Round(0.27 * ltvUsers.Width);
            chLastName.Width = (int)Math.Round(0.27 * ltvUsers.Width);
            chCPF.Width = (int)Math.Round(0.21 * ltvUsers.Width);
            chBalance.Width = (int)Math.Round(0.14 * ltvUsers.Width);
        }

        private int GetId()
        {
            if (ltvUsers.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Selecione um usuario primeiro.", "Alerta", MessageBoxButtons.OK);
                return -1;
            }

            return int.Parse(ltvUsers.SelectedItems[0].Text);
        }

        private void LoadLtvUsers(string userName = "")
        {
            ltvUsers.Items.Clear();
            List<User> users = _service.ListUsers(userName);
            ListViewItem item;
            foreach (User user in users)
            {
                item = new()
                {
                    Text = user.Id.ToString(),
                    SubItems =
                    {
                        user.FirstName,
                        user.LastName,
                        user.CPF,
                        Math.Round(user.Balance, 2).ToString(),
                    }
                };
                ltvUsers.Items.Add(item);
            }
        }

        private void EditUser()
        {
            int id = GetId();
            if (id == -1) return;

            Form frm = new frmUser(id, _currentUserID);
            frm.Show();
        }

        private void DeleteUser()
        {
            int id = GetId();
            if (id == -1) return;

            DialogResult = MessageBox.Show("Deseja mesmo apagar esse usuario? Essa operação é irreversivel", "CUIDADO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                _service.Delete(id);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Texts.Length == 0) LoadLtvUsers();
            LoadLtvUsers();
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            tmrSearch.Start();
        }

        private void tmrSearch_Tick(object sender, EventArgs e)
        {
            tmrSearch.Stop();
            LoadLtvUsers();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form frm = new frmUser(_currentUserID);
            frm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditUser();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }

        private void tmrAjustColun_Tick(object sender, EventArgs e)
        {
            AdjustltvUsersColumns(null, EventArgs.Empty);
            tmrAjustColun.Stop();
        }

        private void ltvUsers_ItemActivate(object sender, EventArgs e)
        {
            EditUser();
        }
    }
}

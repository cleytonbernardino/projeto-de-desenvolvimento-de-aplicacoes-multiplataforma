﻿using ProjetoDesenvolvimentoAplicacoesMultplataforma.Services;

namespace ProjetoDesenvolvimentoAplicacoesMultplataforma
{
    public partial class frmUsers : Form
    {
        private readonly UserService service = new();

        public frmUsers()
        {
            InitializeComponent();
            LoadDgv();
        }

        private int GetId()
        {
            if (dgvUsers.SelectedCells.Count <= 0)
            {
                MessageBox.Show("Selecione um usuario primeiro.", "Alerta", MessageBoxButtons.OK);
                return -1;
            }

            return int.Parse(dgvUsers.SelectedCells[0].Value.ToString());
        }

        private void LoadDgv()
        {
            BindingSource data = new();
            data.DataSource = service.ListUsers();

            dgvUsers.DataSource = data;
            dgvUsers.Columns[0].Visible = false;
        }

        private void UpdateDgv()
        {
            BindingSource data = new();
            data.DataSource = service.GetUsersByName(txtSearch.Texts);

            dgvUsers.DataSource = data;
            dgvUsers.Columns[0].Visible = false;
        }

        private void EditUser()
        {
            int id = GetId();
            if (id == -1) return;

            Form frm = new frmUser(id);
            frm.Show();
        }

        private void DeleteUser()
        {
            int id = GetId();
            if (id == -1) return;

            DialogResult = MessageBox.Show("Deseja mesmo apagar esse usuario? Essa operação é irreversivel", "CUIDADO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                service.Delete(id);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            UpdateDgv();
        }

        private void txtSearch__TextChanged(object sender, EventArgs e)
        {
            tmrSearch.Start();
        }

        private void tmrSearch_Tick(object sender, EventArgs e)
        {
            tmrSearch.Stop();
            UpdateDgv();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form frm = new frmUser();
            frm.Show();
        }

        private void dgvUsers_DoubleClick(object sender, EventArgs e)
        {
            EditUser();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditUser();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }
    }
}

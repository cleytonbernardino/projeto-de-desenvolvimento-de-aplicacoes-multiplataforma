﻿using ProjetoDesenvolvimentoAplicacoesMultplataforma.Dao;
using ProjetoDesenvolvimentoAplicacoesMultplataforma.Services;

namespace ProjetoDesenvolvimentoAplicacoesMultplataforma
{
    public partial class frmVehicles : Form
    {
        // Classe Dao
        private readonly VehicleService service = new();

        public frmVehicles()
        {
            InitializeComponent();
        }

        private int GetId()
        {
            if (dgvVehicle.Rows.Count == 0)
            {
                MessageBox.Show("Selecione um veiculo primeiro", "Alerta");
                return -1;
            }
            try
            {
                return int.Parse(dgvVehicle.SelectedCells[0].Value.ToString());
            } catch
            {
                return -1;
            }
        }

        private void loadVehicles()
        {
            BindingSource data = new();

            data.DataSource = service.GetAllVehicles();
            dgvVehicle.DataSource = data;
            dgvVehicle.Columns[0].Visible = false;
        }

        private void UpdateDgv()
        {
            BindingSource data = new();

            string licensePlate = txtSearch.Texts;
            data.DataSource = service.GetVehiclesByPlate(licensePlate);
            dgvVehicle.DataSource = data;
        }

        private void dgvVehicle_Layout(object sender, LayoutEventArgs e)
        {
            loadVehicles();
        }

        private void dgvVehicle_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = GetId();
            if (id == -1) return;
            frmVehicle frm = new(id);
            frm.Show();
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
            UpdateDgv();
            tmrSearch.Stop();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmVehicle frm = new();
            frm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = GetId();
            if (id == -1) return;
            frmVehicle frm = new(id);
            frm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = GetId();
            if (id == -1) return;

            DialogResult resp =  MessageBox.Show("Deseja mesmo excluir esse veiculo? Essa operação é inreversivel", "CUIDADO", MessageBoxButtons.YesNoCancel);
            if (resp == DialogResult.No || resp == DialogResult.Cancel) return;

            service.DeleteVehicleById(id);
        }
    }
}

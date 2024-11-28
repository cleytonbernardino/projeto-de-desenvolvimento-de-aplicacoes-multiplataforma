using ProjetoDesenvolvimentoAplicacoesMultplataforma.Dao;
using ProjetoDesenvolvimentoAplicacoesMultplataforma.Services;

namespace ProjetoDesenvolvimentoAplicacoesMultplataforma
{
    public partial class frmVehicle : Form
    {
        private readonly VehicleService service = new();
        private int _id = 0;

        private string direction = "mechanic";

        public frmVehicle()
        {
            InitializeComponent();
        }

        public frmVehicle(int id)
        {
            InitializeComponent();
            InitializeEditMode(id);
        }

        private void InitializeEditMode(int id)
        {
            this.Text = "Editar Veículo";
            Vehicle? vehicle = service.GetVehicleById(id);

            if (vehicle is null)
            {
                MessageBox.Show("Erro ao exibir os dados do veículo", "Erro");
                this.Dispose();
            }
            _id = id;
            txtLicensePlate.Texts = vehicle.LicensePlate;
            txtChassiNumber.Texts = vehicle.ChassiNumber;
            txtDailyVehicleRate.Texts = vehicle.DailyVehicleRate.ToString();
            txtColor.Texts = vehicle.Color;
            txtModel.Texts = vehicle.Model;
            mkbRenavam.Texts = vehicle.Renavam;
            //txtObs
            cbxBrand.Text = vehicle.Brand;
            cbxFuelType.Text = vehicle.FuelType;

            txtMileage.Texts = vehicle.Mileage.ToString();

            cbAr.Checked = vehicle.AirConditioning;
            cbEletricGlass.Checked = vehicle.EletricWindows;
            cbEletricLocks.Checked = vehicle.EletricLocks;
            //cbKey.Checked = dao.ke
            cbLincense.Checked = vehicle.Licensed;

            dtpModelYear.Value = vehicle.ModelYear;

            switch (vehicle.Direction)
            {
                case "hydraulics":
                    rbHydraulics.Checked = true;
                    break;
                case "Electrical":
                    rbElectrical.Checked = true;
                    break;
                case "electroHydraulic":
                    rbElectroHydraulic.Checked = true;
                    break;
                default:
                    rbMechanic.Checked = true;
                    break;
            }
        }

        // Seletor de direção
        // REPENSAR ISSO ACHO QUE DA PARA FAZER UTILIANDO UM FOR ASSIM COMO NO COMBO BOX
        private void rbMechanic_CheckedChanged(object sender, EventArgs e)
        {
            direction = "mechanic";
        }

        private void rbHydraulics_CheckedChanged(object sender, EventArgs e)
        {
            direction = "hydraulics";
        }

        private void rbElectrical_CheckedChanged(object sender, EventArgs e)
        {
            direction = "Electrical";
        }

        private void rbElectroHydraulic_CheckedChanged(object sender, EventArgs e)
        {
            direction = "electroHydraulic";
        }

        // Efeito de hover no botão
        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.LightBlue;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.White;
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.Crimson;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.White;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Salmon;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.White;
        }

        // Impede que o input funcione
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //e.Handled = true;
        }

        // Faz com que ao selecionar seguro total todas as opção seja marcadas
        private void cbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAll.Checked) // Marca tudo
            {
                foreach (Control cheq in gpbInsecure.Controls)
                {
                    CheckBox box = (CheckBox)cheq;
                    box.Checked = true;
                }
                return;
            }
            // Desmarca tudo
            foreach (Control cheq in gpbInsecure.Controls)
            {
                CheckBox box = (CheckBox)cheq;
                box.Checked = false;
            }
        }

        // Ações dos botões
        private void btnSave_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new()
            {
                Id = _id,
                LicensePlate = txtLicensePlate.Texts,
                Brand = cbxBrand.Text,
                Renavam = mkbRenavam.Texts,
                Model = txtModel.Texts,
                ChassiNumber = txtChassiNumber.Texts,
                DailyVehicleRate = double.Parse(txtDailyVehicleRate.Texts),
                Color = txtColor.Texts,
                FuelType = cbxFuelType.Text,
                Direction = direction,
                Obs = txtObs.Texts,
                Mileage = int.Parse(txtMileage.Texts.ToString()),
                Licensed = cbLincense.Checked,
                AirConditioning = cbAr.Checked,
                EletricWindows = cbEletricGlass.Checked,
                EletricLocks = cbEletricLocks.Checked,
                ModelYear = dtpModelYear.Value.Date ,
            };

            int id = service.Save(vehicle);
            if (id == -1)
            {
                MessageBox.Show("Erro ao realizar essa tarefa.", "Erro");
                return;
            }
            else if (id > 0)
            {
                this.Text = "Editar Veículo";
                _id = id;
            }
            MessageBox.Show("Ação realizada com sucesso.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja mesmo excluir esse veiculo?", "Cuidado", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (resp != DialogResult.Yes) return;

            if (_id == 0)
            {
                this.Dispose();
            }
            if (service.DeleteVehicleById(_id)) MessageBox.Show("Naõ foi possivel excluir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmVehicle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S) btnSave.PerformClick();
            if (e.Control && e.KeyCode == Keys.Delete) btnDelete.PerformClick();
            if (e.KeyCode == Keys.Escape) btnClose.PerformClick();
        }

        private void txtDailyVehicleRate__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void txtKm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

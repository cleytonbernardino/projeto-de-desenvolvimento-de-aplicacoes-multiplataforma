using ProjetoDesenvolvimentoAplicacoesMultplataforma.Dao;

namespace ProjetoDesenvolvimentoAplicacoesMultplataforma
{
    public partial class frmVehicle : Form
    {
        private readonly VehicleDao dao = new();
        private bool editMode = false;

        private string direction = "mechanic";

        public frmVehicle()
        {
            InitializeComponent();
        }

        public frmVehicle(int id)
        {
            InitializeComponent();
            ChangeToEditMode();
            LoadVehicle(id);
        }

        private void ChangeToEditMode()
        {
            editMode = true;
            this.Text = "Editar Veículo";
        }

        private void LoadVehicle(int id)
        {
            dao.Id = id;
            if (!dao.Select())
            {
                MessageBox.Show("Erro ao exibir os dados do veículo", "Erro");
                this.Dispose();
            }
            txtLicensePlate.Texts = dao.LicensePlate;
            txtChassiNumber.Texts = dao.ChassiNumber;
            txtColor.Texts = dao.Color;
            txtModel.Texts = dao.Model;
            mkbRenavam.Texts = dao.Renavam;
            //txtObs
            cbxBrand.Text = dao.Brand;
            cbxFuelType.Text = dao.FuelType;

            nupMileage.Value = dao.Mileage;

            cbAr.Checked = dao.AirConditioning;
            cbEletricGlass.Checked = dao.EletricWindows;
            cbEletricLocks.Checked = dao.EletricLocks;
            //cbKey.Checked = dao.ke
            cbLincense.Checked = dao.Licensed;

            dtpModelYear.Value = dao.ModelYear;

            switch (dao.Direction)
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
            e.Handled = true;
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
            // Strings
            dao.LicensePlate = txtLicensePlate.Texts;
            dao.Brand = cbxBrand.Text;
            dao.Renavam = mkbRenavam.Texts;
            dao.Model = txtModel.Texts;
            dao.ChassiNumber = txtChassiNumber.Texts;
            dao.Color = txtColor.Texts;
            dao.FuelType = cbxFuelType.Text;
            dao.Direction = direction;
            dao.Obs = txtObs.Texts;

            // Int
            dao.Mileage = int.Parse(nupMileage.Value.ToString());

            // Boolean
            dao.Licensed = cbLincense.Checked;
            dao.AirConditioning = cbAr.Checked;
            dao.EletricWindows = cbEletricGlass.Checked;
            dao.EletricLocks = cbEletricLocks.Checked;

            // Model Year
            dao.ModelYear = dtpModelYear.Value;

            int rows;
            if (editMode)
            {
                rows = dao.Update();
            } else
            {
                rows = dao.Save();
                ChangeToEditMode();
            }
            if (rows == -1) 
            {
                MessageBox.Show("Erro ao realizar essa tarefa.", "Erro");
                return;
            }
            MessageBox.Show("Ação realizada com sucesso.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja mesmo excluir esse veiculo?", "Cuidado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resp == DialogResult.No) return; 

            if (dao.Id == 0)
            {
                this.Dispose();
            }
            if(!dao.Delete()) MessageBox.Show("Naõ foi possivel excluir", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Dispose();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

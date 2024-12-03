using ProjetoDesenvolvimentoAplicacoesMultplataforma.Services;
using ProjetoDesenvolvimentoAplicacoesMultplataforma.Dao;

namespace ProjetoDesenvolvimentoAplicacoesMultplataforma.Forms
{
    public partial class frmRented : Form
    {
        private VehicleService _servicesVehicle = new();
        private UserService _serviceUser = new();
        private TransactionService _serviceTransaction = new();

        private int _vehicleId;

        public frmRented(int vehicleId, string licencePlate, bool isRented)
        {
            InitializeComponent();
            LoadConfig(vehicleId, licencePlate, isRented);
        }

        private void LoadConfig(int vehicleId, string licencePlate, bool isRented)
        {
            _vehicleId = vehicleId;
            txtLicensePlate.Texts = licencePlate;
            LoadLtvRecord();
            if (isRented)
            {
                Vehicle vehicle = _servicesVehicle.GetVehicleById(vehicleId);
                User user = _serviceUser.GetUserById(vehicle.RentedBy);
                dtpReturnDay.MinDate = GetVehicle().RentalExpiration;
                btnRent.Enabled = false;
                btnCancelRental.Visible = true;
                txtName.Texts = user.FirstName + " " + user.LastName;
                mkbCPF.Texts = user.CPF;
                mkbCPF.Enabled = false;
                return;
            }
            dtpReturnDay.MinDate = DateTime.Now;
            btnRent.Visible = true;
            btnCancelRental.Visible = false;
        }

        private void LoadLtvRecord()
        {
            ltvRecord.Items.Clear();
            List<RentalHistory> rentalHistory = _servicesVehicle.GetRentalHistory(_vehicleId);
            ListViewItem item;
            foreach (RentalHistory history in rentalHistory)
            {
                item = new(history.UserId.ToString());
                item.SubItems.Add(history.RentalDate.ToShortDateString());
                item.SubItems.Add(history.RentalExpiration.ToShortDateString());
                item.SubItems.Add(history.RentalValue.ToString());
                ltvRecord.Items.Add(item);
            }
        }

        private Vehicle GetVehicle()
        {
            Vehicle vehicle = _servicesVehicle.GetVehicleById(_vehicleId);
            if (vehicle is null) throw new Exception("Veículo não encontrado");
            return vehicle;
        }

        private User GetUser()
        {
            string cpf = mkbCPF.Texts;
            if (!Utils.cpfUtils.IsCpfValid(cpf)) throw new Exception("CPF INVALIDO");
            User user = _serviceUser.GetUserByCpf(cpf);
            if (user is null) throw new Exception("Usuario não encontrado");
            return user;
        }

        private int GetTotalDays()
        {
            return (dtpReturnDay.Value.Date - dtpStartingDay.Value.Date).Days;
        }

        private double GetRentalValue()
        {
            return _servicesVehicle.CalculateRent(GetTotalDays(), _vehicleId);
        }

        private void mkbCPF_Enter(object sender, EventArgs e)
        {
            mkbCPF.UnderlineStyle = true;
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if (Utils.cpfUtils.IsCpfValid(mkbCPF.Texts))
            {
                try
                {
                    mkbCPF.BorderColor = Color.SeaGreen;
                    mkbCPF.UnderlineStyle = true;
                    User user = GetUser();
                    txtName.Texts = user.FirstName + " " + user.LastName;
                    return;
                }
                catch
                {
                    // Não fazer nada
                }
            }
            mkbCPF.BorderColor = Color.Red;
            mkbCPF.UnderlineStyle = false;
            txtName.Texts = "";
        }

        private void mkbCPF__TextChanged(object sender, EventArgs e)
        {
            if (mkbCPF.Texts.Length == 14 && Utils.cpfUtils.IsCpfValid(mkbCPF.Texts)) dtpReturnDay.Focus();
        }

        private void dtpReturnDay_ValueChanged(object sender, EventArgs e)
        {
            lblDaysRemainingValue.Text = GetTotalDays().ToString();
            lblTotalValue.Text = GetRentalValue().ToString();
        }

        private void dtpStartingDay_ValueChanged(object sender, EventArgs e)
        {
            lblDaysRemainingValue.Text = GetTotalDays().ToString();
            lblTotalValue.Text = GetRentalValue().ToString();
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            double rentalValue = _servicesVehicle.CalculateRent(GetTotalDays(), _vehicleId);
            double userBalance = _serviceUser.GetUserBalance(mkbCPF.Texts);
            if (userBalance < rentalValue)
            {
                MessageBox.Show("Saldo insuficiente", "Alerta");
                return;
            }
            bool result = _serviceTransaction.RentVehicle(
                _vehicleId,
                GetRentalValue(),
                GetUser().Id,
                dtpStartingDay.Value.Date,
                dtpReturnDay.Value.Date
            );
            if (!result)
            {
                MessageBox.Show("Erro ao realizar essa tarefa.", "Erro");
                return;
            }
            MessageBox.Show("Salvo com sucesso");
        }

        private void btnCancelRental_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show(
                $"Deseja mesmo cancelar esse alguel ainda restam {GetTotalDays()} Dias, será devolvido o valor de {GetRentalValue()} Reais",
                "Alerta Operação IRREVERSÍVEL", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question
            );
            if (resp != DialogResult.Yes) return;
            
            double reversal = _serviceTransaction.CancelRent(_vehicleId, GetRentalValue());
            if (reversal == -1)
            {
                MessageBox.Show("Erro ao cancelar o aluguel", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show(
                $"Cancelado com sucesso foi realizado um estorno de R$: {reversal}.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information
            );
            this.Close();
        }

        private void frmRented_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S) btnRent.PerformClick();
            if (e.KeyCode == Keys.Escape) this.Dispose();
        }
    }
}

using ProjetoDesenvolvimentoAplicacoesMultplataforma.Services;
using ProjetoDesenvolvimentoAplicacoesMultplataforma.Dao;

namespace ProjetoDesenvolvimentoAplicacoesMultplataforma.Forms
{
    public partial class frmRented : Form
    {
        private VehicleService _servicesVehicle = new();
        private UserService _serviceUser = new();

        public frmRented(int id)
        {
            InitializeComponent();
            LoadVehicle(id);
        }

        private void LoadVehicle(int id)
        {
            Vehicle? vehicle = _servicesVehicle.GetVehicleById(id);
            if (vehicle is null) throw new Exception("Veículo não encontrado.");
            txtLicensePlate.Texts = vehicle.LicensePlate;
        }

        private bool CPFIsValid()
        {
            string cpf = Utils.cpfUtils.ToCpf(mkbCPF.Texts);
            return Utils.cpfUtils.IsCpfValid(cpf);
        }

        private User GetUser()
        {
            if (!CPFIsValid()) throw new Exception("CPF INVALIDO");
            return _serviceUser.GetUserByCpf(Utils.cpfUtils.ToCpf(mkbCPF.Texts));
        }

        private void mkbCPF_Enter(object sender, EventArgs e)
        {
            mkbCPF.UnderlineStyle = true;
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if (!CPFIsValid())
            {
                mkbCPF.BorderColor = Color.Red;
                mkbCPF.UnderlineStyle = false;
                txtName.Texts = "";
                return;
            }
            mkbCPF.BorderColor = Color.SeaGreen;
            mkbCPF.UnderlineStyle = true;
            User user = GetUser();
            txtName.Texts = user.FirstName + " " + user.LastName;
        }

        private void mkbCPF__TextChanged(object sender, EventArgs e)
        {
            if (mkbCPF.Texts.Length == 14 && CPFIsValid()) dtpReturnDay.Focus();
        }
    }
}

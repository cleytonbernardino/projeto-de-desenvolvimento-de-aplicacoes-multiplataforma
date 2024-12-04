using ProjetoDesenvolvimentoAplicacoesMultplataforma.Services;

namespace ProjetoDesenvolvimentoAplicacoesMultplataforma.Forms.DialogBox
{
    public partial class FirstUse : Form
    {
        public int UserID { get; private set; }

        private readonly UserService _service = new();

        public FirstUse()
        {
            InitializeComponent();
        }

        private string GetCPF()
        {
            string cpf = mkbCPF.Texts;
            cpf = cpf.Replace(".", "").Replace("-", "");
            return cpf;
        }

        private bool isValidCPF()
        {
            return Utils.cpfUtils.IsCpfValid(mkbCPF.Texts);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isValidCPF())
            {
                MessageBox.Show("CPF invalido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int resp = _service.FirstUse(
                txtFirstName.Texts, GetCPF(), txtUsername.Texts, txtPassword.Texts
            );
            UserID = resp;

            if (resp == -1)
                MessageBox.Show("Não foi possivel criar esse usuario", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Dispose();
        }

        private void txtPassword__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) btnSave.PerformClick();
        }

        private void mkbCPF__MouseClick(object sender, EventArgs e)
        {
            mkbCPF.Select(0, 0);
        }

        private void mkbCPF_Enter(object sender, EventArgs e)
        {
            mkbCPF.BorderColor = Color.SeaGreen;
        }

        private void mkbCPF_Leave(object sender, EventArgs e)
        {
            if (!isValidCPF()) mkbCPF.BorderColor = Color.Red;
            else  mkbCPF.BorderColor = Color.SeaGreen;
        }
    }
}

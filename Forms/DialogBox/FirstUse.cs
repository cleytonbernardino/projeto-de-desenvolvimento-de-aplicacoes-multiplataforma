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

        private void btnSave_Click(object sender, EventArgs e)
        {
            int resp;
            try
            {
                resp = _service.FirstUse(txtFirstName.Texts, txtUsername.Texts, txtPassword.Texts);
                UserID = resp;
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPassword__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) btnSave.PerformClick();
        }
    }
}

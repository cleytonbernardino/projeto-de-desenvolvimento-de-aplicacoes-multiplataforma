namespace ProjetoDesenvolvimentoAplicacoesMultplataforma
{
    public partial class frmLogin : Form
    {
        public bool IsLogged { get; private set; } = false;
        public int UserId { get; private set; } = -1;

        private readonly Services.UserService _service = new();

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSeePassword_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = !txtPassword.PasswordChar;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            int status = _service.Login(txtUsername.Texts, txtPassword.Texts);
            if (status != -1)
            {
                IsLogged = true;
                if (status == 1)
                {
                    Forms.DialogBox.FirstUse dialog = new();
                    dialog.ShowDialog();
                    UserId = dialog.UserID;
                    this.Close();
                }
                UserId = status;
                this.Close();
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos", "Erro");
            }
        }

        private void txtPassword__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) btnSignIn.PerformClick();
        }
    }
}

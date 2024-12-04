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
            string username = txtUsername.Texts;
            string password = txtPassword.Texts;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Preencha todos os campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int status = _service.Login(username, password);
            if (status != -1)
            {
                IsLogged = true;
                if (status == 1)
                {
                    Forms.DialogBox.FirstUse dialog = new();
                    dialog.ShowDialog();
                    UserId = dialog.UserID;
                    this.Close();
                } else 
                {
                    UserId = status;
                    this.Close();
                }
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

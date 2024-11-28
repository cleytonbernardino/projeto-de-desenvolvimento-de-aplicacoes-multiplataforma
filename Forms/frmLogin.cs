namespace ProjetoDesenvolvimentoAplicacoesMultplataforma
{
    public partial class frmLogin : Form
    {
        public bool IsLogged { get; private set; } = true;

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
            this.Close();
        }
    }
}

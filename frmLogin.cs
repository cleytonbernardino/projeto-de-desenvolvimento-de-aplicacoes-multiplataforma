namespace ProjetoDesenvolvimentoAplicacoesMultplataforma
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnSeePassword_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = !txtPassword.PasswordChar;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
        }
    }
}

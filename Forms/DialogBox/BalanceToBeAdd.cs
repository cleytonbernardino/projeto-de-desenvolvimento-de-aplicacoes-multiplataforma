namespace ProjetoDesenvolvimentoAplicacoesMultplataforma.Forms.DialogBox
{
    public partial class BalanceToBeAdd : Form
    {
        public double Value { get; private set; }

        public BalanceToBeAdd()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtValue__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Enter)) btnSave.PerformClick();
            if (e.KeyChar == ((char)Keys.Escape)) btnCancel.PerformClick();
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Value = double.Parse(txtValue.Texts);
        }
    }
}

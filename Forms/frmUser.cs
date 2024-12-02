using ProjetoDesenvolvimentoAplicacoesMultplataforma.Dao;
using ProjetoDesenvolvimentoAplicacoesMultplataforma.Services;

namespace ProjetoDesenvolvimentoAplicacoesMultplataforma
{
    public partial class frmUser : Form
    {
        public int UserID { get; private set; }

        private int _id = 0;
        private readonly int _currentUserId;
        private string _cpf = "";

        private readonly UserService _service = new();

        public frmUser(int currentUserID)
        {
            InitializeComponent();
            _currentUserId = currentUserID;
        }

        public frmUser(int id, int currentUserId)
        {
            InitializeComponent();
            InitEditMode(id);
            _currentUserId = currentUserId;
        }

        private void InitEditMode(int id)
        {
            User user = _service.GetUserById(id);
            if (user is null)
            {
                MessageBox.Show("Erro ao carregar o usuario.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
                return;
            }

            _id = id;
            _cpf = user.CPF;
            txtFirstName.Texts = user.FirstName;
            txtLastName.Texts = user.LastName;
            txtEmail.Texts = user.Email;
            lblBalanceValue.Text = Math.Round(user.Balance, 2).ToString();
            dtpDateOfBirth.Value = user.BirtyDay;
            mkbCPF.Texts = user.CPF;
            mkbCNH.Texts = "000" + user.CNH;
            cbxRoles.Text = user.Role;

            mkbCPF.Enabled = false;
            mkbCNH.Enabled = false;
            ltvViolation.Enabled = true;
            txtViolationType.Enabled = true;
            txtViolationValue.Enabled = true;
            btnViolationAdd.Enabled = true;
            listView2.Enabled = true;
            btnRentalRecordAdd.Enabled = true;

            ptbAddBalance.Visible = true;
            LoadLtvViolation();
        }

        private void LoadLtvViolation()
        {
            ltvViolation.Items.Clear();
            ListViewItem lvItem;
            List<Violation> violations = _service.GetPenaltysByOwnerId(_id);

            foreach (Violation violation in violations)
            {
                lvItem = new ListViewItem(violation.Id.ToString());
                lvItem.SubItems.Add(violation.Name);
                lvItem.SubItems.Add(Math.Round(violation.Cost, 2).ToString());
                lvItem.SubItems.Add("");
                ltvViolation.Items.Add(lvItem);
            }
        }

        private bool IsViolationSelected(bool showMessage = true)
        {
            if (ltvViolation.SelectedItems.Count <= 0)
            {
                if (showMessage) MessageBox.Show("Selecione um item primeiro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private bool CanDrive()
        {
            DateTime birth = dtpDateOfBirth.Value.Date;
            return birth.AddYears(18) <= DateTime.Now;
        }

        private void LoadViolationToEdit()
        {
            ListViewItem item = ltvViolation.SelectedItems[0];
            txtViolationType.Texts = item.SubItems[1].Text;
            txtViolationValue.Texts = item.SubItems[2].Text;
            ltvViolation.Enabled = false;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnViolationAdd.Visible = false;
            btnEditViolation.Visible = true;
        }

        private void AddViolationToList()
        {
            string name = txtViolationType.Texts;
            double cost;
            try
            {
                if (string.IsNullOrEmpty(name)) throw new Exception("Valor Invalido");
                cost = double.Parse(txtViolationValue.Texts);
            }
            catch
            {
                MessageBox.Show("Insira um valor valido!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ListViewItem lvt = new("Não Salvo");
            lvt.SubItems.Add(name);
            lvt.SubItems.Add(cost.ToString());
            lvt.SubItems.Add("A");
            ltvViolation.Items.Add(lvt);

            txtViolationType.Texts = "";
            txtViolationValue.Texts = "";
            txtViolationType.Focus();
        }

        private (List<Violation> Additions, List<Violation> Edits, List<Violation> Remove) SaveViolations()
        {
            int id;
            List<Violation> violationsToBeAdd = new();
            List<Violation> violationsToBeEdit = new();
            List<Violation> violationsToBeRemoved = new();
            Violation violation;

            foreach (ListViewItem violationItem in ltvViolation.Items)
            {
                try
                {
                    if (string.IsNullOrEmpty(violationItem.SubItems[3].Text)) continue;
                }
                catch
                {
                    return (violationsToBeAdd, violationsToBeEdit, violationsToBeRemoved);
                }
                violation = new()
                {
                    Id = 0,
                    OwnerId = _id,
                    Name = violationItem.SubItems[1].Text,
                    Cost = double.Parse(violationItem.SubItems[2].Text),
                };
                if (violationItem.SubItems[3].Text == "A")
                {
                    violationsToBeAdd.Add(violation);
                }
                else if (violationItem.SubItems[3].Text == "E")
                {
                    id = int.Parse(violationItem.Text);
                    violation.Id = id;
                    violationsToBeEdit.Add(violation);
                }
                else
                {
                    id = int.Parse(violationItem.Text);
                    violation.Id = id;
                    violationsToBeRemoved.Add(violation);
                }

            }
            return (violationsToBeAdd, violationsToBeEdit, violationsToBeRemoved);
        }

        private void EditViolation()
        {
            string name = txtViolationType.Texts;
            double cost;

            try
            {
                if (string.IsNullOrEmpty(name)) throw new Exception("Valor Invalido");
                cost = double.Parse(txtViolationValue.Texts);
            }
            catch
            {
                MessageBox.Show("Insira um valor valido!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ListViewItem item = ltvViolation.SelectedItems[0];

            item.SubItems[1].Text = name;
            item.SubItems[2].Text = cost.ToString();
            item.SubItems[3].Text = "E";
            ltvViolation.Enabled = true;
            btnSave.Enabled = false;
            btnDelete.Enabled = false;
            btnViolationAdd.Visible = true;
            btnEditViolation.Visible = false;
        }

        private void RemoveViolation()
        {
            if (!IsViolationSelected()) return;

            if (ltvViolation.SelectedItems[0].Text == "Não Salvo")
            {
                int ltvIndex = ltvViolation.SelectedItems[0].Index;
                ltvViolation.Items.RemoveAt(ltvIndex);
                return;
            }
            ltvViolation.SelectedItems[3].Text = "D";
        }

        private void Save()
        {
            if (!CanDrive())
            {
                MessageBox.Show("O locatario é menor de idade", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string role = role = _service.GetRole(_currentUserId, cbxRoles.Text);
            if (role == "NA")
            {
                MessageBox.Show("Cargo invalido, ou usuário sem permição", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            (
                List<Violation> ViolationAdd, List<Violation> ViolationEdit, List<Violation> ViolationRem
            ) = SaveViolations();
            int id = _service.Save(
                _id,
                txtFirstName.Texts,
                txtLastName.Texts,
                txtEmail.Texts,
                mkbCPF.Texts,
                mkbCNH.Texts.Substring(3, 9), // Ignora os zeros, talvez mudar no banco de dados para suportar
                double.Parse(lblBalanceValue.Text),
                role,
                dtpDateOfBirth.Value.Date,
                ViolationAdd,
                ViolationEdit,
                ViolationRem
            );
            if (id == -2)
            {
                MessageBox.Show("CPF INCORRETO", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (id == -1)
            {
                MessageBox.Show("Não foi possivel salvar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Salvo com sucesso", "Sucesso");

            if (id > 0)
            {
                InitEditMode(id);
                return;
            }
            LoadLtvViolation();
            lblBalanceValue.Text = Math.Round(_service.GetUserBalance(_cpf), 2).ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show(
                "Deseja Mesmo excluir esse usuario? Essa operaçãoo é inreversivel.", "CUIDADO", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question
            );
            if (resp == DialogResult.Yes && _id != 0) _service.Delete(_id);
            this.Dispose();
        }

        private void btnPenaltyAdd_Click(object sender, EventArgs e)
        {
            AddViolationToList();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddViolationToList();
        }

        private void apagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveViolation();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsViolationSelected()) return;
            LoadViolationToEdit();
        }

        private void btnEditPenalty_Click(object sender, EventArgs e)
        {
            EditViolation();
            txtViolationType.Texts = "";
            txtViolationValue.Texts = "";
            txtViolationType.Focus();
        }

        private void ltvPenalty_DoubleClick(object sender, EventArgs e)
        {
            if (!IsViolationSelected(false)) return;
            LoadViolationToEdit();
        }

        private void ptbAddBalance_Click(object sender, EventArgs e)
        {
            Forms.DialogBox.BalanceToBeAdd balanceDialog = new();
            if (balanceDialog.ShowDialog() == DialogResult.Cancel) return;

            double balance = double.Parse(lblBalanceValue.Text);
            balance += balanceDialog.Value;
            lblBalanceValue.Text = balance.ToString();
        }

        private void frmUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S) Save();
        }

        private void mkbCPF__MouseClick(object sender, EventArgs e)
        {
            mkbCPF.Select(0, 0);
        }

        private void mkbCNH__MouseClick(object sender, EventArgs e)
        {
            mkbCNH.Select(0, 0);
        }

        private void frmUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            (List<Violation> addList, List<Violation> editList, List<Violation> removeList) = SaveViolations();
            if (addList.Count == 0 && editList.Count == 0 && removeList.Count == 0) return;
            DialogResult resp = MessageBox.Show(
                "Há alterações não salvas deseja salvar(Ctrl + s)?", "Alerta", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question
            );
            if (resp == DialogResult.Yes) Save();
        }
    }
}

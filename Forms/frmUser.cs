using ProjetoDesenvolvimentoAplicacoesMultplataforma.Dao;
using ProjetoDesenvolvimentoAplicacoesMultplataforma.Services;

namespace ProjetoDesenvolvimentoAplicacoesMultplataforma
{
    public partial class frmUser : Form
    {
        private int _id = 0;

        private readonly List<int> _violationToBeRemoved = [];
        private readonly UserService _service = new();

        public frmUser()
        {
            InitializeComponent();
        }

        public frmUser(int id)
        {
            InitializeComponent();
            InitEditMode(id);
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
            txtFirstName.Texts = user.FirstName;
            txtLastName.Texts = user.LastName;
            txtEmail.Texts = user.Email;
            lblBalanceValue.Text = user.Balance.ToString();
            mkbCPF.Texts = user.CPF;
            mkbCNH.Texts = user.CNH;

            mkbCPF.Enabled = false;
            mkbCNH.Enabled = false;
            ltvViolation.Enabled = true;
            txtViolationType.Enabled = true;
            txtViolationValue.Enabled = true;
            btnViolationAdd.Enabled = true;
            listView2.Enabled = true;
            btnRentalRecordAdd.Enabled = true;
            LoadLtvViolation();
        }

        private void LoadLtvViolation()
        {
            ltvViolation.Items.Clear();
            ListViewItem lvItem;
            List<ViolationDao.Penalty> violations = _service.GetPenaltysByOwnerId(_id);

            foreach (ViolationDao.Penalty violation in violations)
            {
                lvItem = new ListViewItem(violation.Id.ToString());
                lvItem.SubItems.Add(violation.Name);
                lvItem.SubItems.Add(violation.Cost.ToString());
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

        private void LoadViolationToEdit()
        {
            ListViewItem item = ltvViolation.SelectedItems[0];
            txtViolationType.Texts = item.SubItems[1].Text;
            txtViolationValue.Texts = item.SubItems[2].Text;
            ltvViolation.Enabled = false;
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
            ltvViolation.Items.Add(lvt);

            txtViolationType.Texts = "";
            txtViolationValue.Texts = "";
            txtViolationType.Focus();
        }

        private List<ViolationDao.Penalty> SaveViolations()
        {
            int id;
            List<ViolationDao.Penalty> violationsList = new();

            foreach (ListViewItem violationItem in ltvViolation.Items)
            {
                try
                {
                    id = int.Parse(violationItem.SubItems[0].Text);
                }
                catch
                {
                    id = 0;
                }

                ViolationDao.Penalty violation = new()
                        {
                            Id = id,
                            OwnerId = _id,
                            Name = violationItem.SubItems[1].Text,
                            Cost = float.Parse(violationItem.SubItems[2].Text),
                        };
                violationsList.Add(violation);
            }
            return violationsList;
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
            ltvViolation.Enabled = true;
            btnViolationAdd.Visible = true;
            btnEditViolation.Visible = false;
        }

        private void RemoveViolation()
        {
            if (!IsViolationSelected()) return;
            int id;
            try
            {
                id = int.Parse(ltvViolation.SelectedItems[0].Text);
                _violationToBeRemoved.Add(id);
            }
            catch
            {
                //Não fazer nada
            }
            int ltvIndex = ltvViolation.SelectedItems[0].Index;
            ltvViolation.Items.RemoveAt(ltvIndex);
        }

        private void Save()
        {
            List<ViolationDao.Penalty> violations = SaveViolations();
            int id = _service.Save(
                _id,
                txtFirstName.Texts,
                txtLastName.Texts,
                txtEmail.Texts,
                mkbCPF.Texts,
                mkbCNH.Texts,
                dtpDateOfBirth.Value,
                violations,
                _violationToBeRemoved
            );

            if (id == -1) MessageBox.Show("Não foi possivel salvar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show("Salvo com sucesso", "Sucesso");
            if (id > 0)
            {
                InitEditMode(id);
                return;
            }
            LoadLtvViolation();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
    }
}

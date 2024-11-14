using ProjetoDesenvolvimentoAplicacoesMultplataforma.Dao;
using ProjetoDesenvolvimentoAplicacoesMultplataforma.Utils;

namespace ProjetoDesenvolvimentoAplicacoesMultplataforma
{
    public partial class frmPessoa : Form
    {
        private readonly UserDao dao = new();
        private readonly PenaltyDao daoPenalty = new();
        private List<PenaltyDao.Penalty> penaltiesToBeAdded = [];
        private List<PenaltyDao.Penalty> penaltiesToBeUpdated = [];
        private List<int> penaltiesToBeRemoved = [];
        private bool editMode = false;

        // LEMBRAR DE CORRIGIR OS ERROS GRAMATICAL E REFINAR O CODIGO

        public frmPessoa()
        {
            InitializeComponent();
        }

        public frmPessoa(int id)
        {
            InitializeComponent();
            try
            {
                InitEditMode(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }
        }

        private void InitEditMode(int id)
        {
            dao.Id = id;
            bool status = dao.Select();
            if (!status)
            {
                MessageBox.Show("Erro ao carregar o usuario", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception("Erro ao carregar o usuario.");
            }

            editMode = true;
            txtFirstName.Texts = dao.FirstName;
            txtLastName.Texts = dao.LastName;
            txtEmail.Texts = dao.Email;
            lblBalanceValue.Text = dao.Balance.ToString();

            mkbCPF.Texts = dao.CPF;
            mkbCNH.Texts = dao.CNH;
            mkbCPF.Enabled = false;
            mkbCNH.Enabled = false;
            LoadLtvPenalty();
        }

        private void LoadLtvPenalty()
        {
            ListViewItem lvItem;
            List<PenaltyDao.Penalty> penalties = daoPenalty.List(dao.Id);

            foreach (PenaltyDao.Penalty penalty in penalties)
            {
                lvItem = new ListViewItem(penalty.Id.ToString());
                lvItem.SubItems.Add(penalty.Name);
                lvItem.SubItems.Add(penalty.Cost.ToString());
                ltvPenalty.Items.Add(lvItem);
            }
        }

        private string formatCpf()
        {
            string cpf = mkbCPF.Texts;
            cpf = cpf.Replace(".", "").Replace("-", "");
            return cpf;
        }

        private bool IsPenaltySelected()
        {
            if (ltvPenalty.SelectedItems.Count <= 0)
            {
                MessageBox.Show("Selecione um item primeiro", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void AddPenalty()
        {
            string name = txtPenaltyType.Texts;
            double cost;
            try
            {
                if (string.IsNullOrEmpty(name)) throw new Exception("Valor Invalido");
                cost = double.Parse(txtPenaltyValue.Texts);
            }
            catch
            {
                MessageBox.Show("Insira um valor valido!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ListViewItem lvt = new("Não Salvo");
            lvt.SubItems.Add(name);
            lvt.SubItems.Add(cost.ToString());

            PenaltyDao.Penalty penalty = new();
            penalty.OwnerId = dao.Id;
            penalty.Name = name;
            penalty.Cost = cost;

            ltvPenalty.Items.Add(lvt);
            penaltiesToBeAdded.Add(penalty);

            txtPenaltyType.Texts = "";
            txtPenaltyValue.Texts = "";
            txtPenaltyType.Focus();
        }

        private void EditPenalty()
        {
            string name = txtPenaltyType.Texts;
            double cost;

            try
            {
                if (string.IsNullOrEmpty(name)) throw new Exception("Valor Invalido");
                cost = double.Parse(txtPenaltyValue.Texts);
            } catch
            {
                MessageBox.Show("Insira um valor valido!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ltvPenalty.SelectedItems[1].Text = name;
            ltvPenalty.SelectedItems[2].Text = cost.ToString();

            try
            {
                int id = int.Parse(ltvPenalty.SelectedItems[0].Text);
                PenaltyDao.Penalty penalty = new();
                penalty.Id = id;
                penalty.Name = name;
                penalty.Cost = cost;
                penaltiesToBeUpdated.Add(penalty);
            } catch
            {
                return;
            }
        }

        private void RemovePenalty()
        {
            if (!IsPenaltySelected()) return;
            try
            {
                int id = int.Parse(ltvPenalty.SelectedItems[0].Text);
                penaltiesToBeRemoved.Add(id);
            }
            catch
            {
                //Não fazer nada
            }
            int ltvIndex = ltvPenalty.SelectedItems[0].Index;
            ltvPenalty.Items.RemoveAt(ltvIndex);
        }

        private void CommitPenalty()
        {
            if (penaltiesToBeAdded.Count > 0)
            {
                daoPenalty.Save(penaltiesToBeAdded);
                penaltiesToBeAdded.Clear();
            }
            if (penaltiesToBeRemoved.Count > 0)
            {
                daoPenalty.Delete(penaltiesToBeRemoved);
                penaltiesToBeRemoved.Clear();
            }
            if (penaltiesToBeUpdated.Count > 0)
            {
                daoPenalty.Update(penaltiesToBeUpdated);
                penaltiesToBeUpdated.Clear();
            }
            ltvPenalty.Clear();
            LoadLtvPenalty();
        }

        private float GetBalance()
        {
            return (float)1;
        }

        private void Save()
        {
            dao.FirstName = txtFirstName.Texts;
            dao.LastName = txtLastName.Texts;
            dao.Email = txtEmail.Texts;
            dao.CNH = mkbCNH.Texts;
            dao.BirtyDay = dtpDateOfBirth.Value;
            dao.Balance = GetBalance();

            if (editMode)
            {
                dao.Update();
            }
            else
            {
                string cpf = formatCpf();
                if (!Validations.IsCpfValid(cpf))
                {
                    MessageBox.Show("CPF Invalido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                dao.CPF = cpf;
                dao.Save();
            }
            CommitPenalty();
            MessageBox.Show("Salvo com sucesso", "Mensagem");
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
            if (resp == DialogResult.Yes)
            {
                dao.Delete();
            }
        }

        private void btnPenaltyAdd_Click(object sender, EventArgs e)
        {
            AddPenalty();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPenalty();
        }

        private void apagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemovePenalty();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsPenaltySelected()) return;
            txtPenaltyType.Texts = ltvPenalty.SelectedItems[1].Text;
            txtPenaltyValue.Texts = ltvPenalty.SelectedItems[2].Text;
            EditPenalty();
        }
    }
}

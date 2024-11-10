using ProjetoDesenvolvimentoAplicacoesMultplataforma.Dao;

namespace ProjetoDesenvolvimentoAplicacoesMultplataforma
{
    public partial class frmPessoa : Form
    {
        private readonly UserDao dao = new();
        private readonly PenaltyDao daoPenalty = new();
        private bool editMode = false;

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
        }

        private string formatCpf()
        {
            string cpf = mkbCPF.Texts;
            cpf = cpf.Replace(".", "").Replace("-", "");
            return cpf;
        }

        // Colocar o nome dessa função em inglês
        // DESAFIO deixa esse codigo menor BEM menos, isso vai me ajudar com a logica de programação
        private bool VerificaCPF()
        {
            string cpf = formatCpf();
            int num, i, mult;
            int firstDigit = 0;
            int secondDigit = 0;

            mult = 1;
            for (i = 0; i < (cpf.Length - 2); i++)
            {
                try
                {
                    num = int.Parse(cpf.Substring(i, 1));
                    firstDigit += num * mult;
                    mult++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao validar o cpf: " + ex.Message, "MENSAGEM DE DEBUG");
                    return false;
                }
            }
            firstDigit = firstDigit % 11;
            if (firstDigit >= 10) firstDigit = 0;

            mult = 0;
            for (i = 0; i < (cpf.Length - 1); i++)
            {
                try
                {
                    num = int.Parse(cpf.Substring(i, 1));
                    secondDigit += num * mult;
                    mult++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao validar o cpf: " + ex.Message, "MENSAGEM DE DEBUG");
                    return false;
                }
            }
            secondDigit = secondDigit % 11;
            if (secondDigit >= 10) secondDigit = 0;

            string cpfVerficado = cpf.Substring(0, 9) + firstDigit + secondDigit;
            if (cpfVerficado != cpf) return false;
            return true;
        }

        private void AddPenalty(string name, float value)
        {
            ListViewItem lvt = new(name);
            lvt.SubItems.Add(value.ToString());

            ltvtxtPenalty.Items.Add(lvt);
            return;
        }

        private float GetBalance()
        {
            return (float)1;
        }

        private void LoadPenalty()
        {
            return;
        }

        private void SavePenalty()
        {
            PenaltyDao.Penalty penalty = new();
            List<PenaltyDao.Penalty> penaltyList = new();
            ListView.ListViewItemCollection items = ltvtxtPenalty.Items;

            foreach (ListViewItem item in items)
            {
                try
                {
                    penalty.OwnerId = dao.Id;
                    penalty.Name = item.SubItems[0].Text;
                    penalty.Value = float.Parse(item.SubItems[1].ToString());

                    penaltyList.Add(penalty);
                } catch
                {
                    throw new Exception("Uma penalidade não é um valor validado, Apenas numeros são aceitos");
                }
            }
            daoPenalty.Save(penaltyList);
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
                if (!(VerificaCPF()))
                {
                    MessageBox.Show("CPF Invalido", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                dao.CPF = formatCpf();
                dao.Save();
            }
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
            string penalidadeNome = txtPenaltyType.Texts;
            float penalidadeValor;
            try
            {
                penalidadeValor = float.Parse(txtPenaltyValue.Texts);
            }
            catch
            {
                penalidadeValor = 243;
                //MessageBox.Show("Insira um valor Validado para a penalidade");
                //return;
            }

            //if (String.IsNullOrEmpty(penalidadeNome))
            //{
            //    MessageBox.Show("Insira um noem valido para a penalidade");
            //    return;
            //}

            AddPenalty(penalidadeNome, penalidadeValor);
            GetBalance();
        }
    }
}

namespace ProjetoDesenvolvimentoAplicacoesMultplataforma;

partial class frmUsers
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        btnDelete = new CustomControls.CustomButton();
        btnEdit = new CustomControls.CustomButton();
        btnSearch = new CustomControls.CustomButton();
        btnAdd = new CustomControls.CustomButton();
        txtSearch = new CustomControls.CustomTextBox();
        dgvUsers = new DataGridView();
        tmrSearch = new System.Windows.Forms.Timer(components);
        label1 = new Label();
        ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
        SuspendLayout();
        // 
        // btnDelete
        // 
        btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnDelete.BackColor = Color.FromArgb(235, 146, 149);
        btnDelete.BackgroudColor = Color.FromArgb(235, 146, 149);
        btnDelete.BorderColor = Color.PaleVioletRed;
        btnDelete.BorderRadius = 40;
        btnDelete.BorderSize = 0;
        btnDelete.FlatAppearance.BorderSize = 0;
        btnDelete.FlatAppearance.MouseOverBackColor = Color.Red;
        btnDelete.FlatStyle = FlatStyle.Flat;
        btnDelete.ForeColor = Color.Black;
        btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
        btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
        btnDelete.Location = new Point(741, 51);
        btnDelete.Name = "btnDelete";
        btnDelete.Size = new Size(150, 40);
        btnDelete.TabIndex = 13;
        btnDelete.Text = "Apagar";
        btnDelete.TextColor = Color.Black;
        btnDelete.UseVisualStyleBackColor = false;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnEdit
        // 
        btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnEdit.BackColor = Color.FromArgb(90, 71, 255);
        btnEdit.BackgroudColor = Color.FromArgb(90, 71, 255);
        btnEdit.BorderColor = Color.FromArgb(75, 131, 193);
        btnEdit.BorderRadius = 40;
        btnEdit.BorderSize = 0;
        btnEdit.FlatAppearance.BorderSize = 0;
        btnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(75, 131, 193);
        btnEdit.FlatStyle = FlatStyle.Flat;
        btnEdit.ForeColor = Color.Black;
        btnEdit.Image = (Image)resources.GetObject("btnEdit.Image");
        btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
        btnEdit.Location = new Point(585, 51);
        btnEdit.Name = "btnEdit";
        btnEdit.Size = new Size(150, 40);
        btnEdit.TabIndex = 12;
        btnEdit.Text = "Editar";
        btnEdit.TextColor = Color.Black;
        btnEdit.UseVisualStyleBackColor = false;
        btnEdit.Click += btnEdit_Click;
        // 
        // btnSearch
        // 
        btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnSearch.BackColor = Color.FromArgb(110, 189, 244);
        btnSearch.BackgroudColor = Color.FromArgb(110, 189, 244);
        btnSearch.BorderColor = Color.PaleVioletRed;
        btnSearch.BorderRadius = 40;
        btnSearch.BorderSize = 0;
        btnSearch.FlatAppearance.BorderSize = 0;
        btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(87, 149, 194);
        btnSearch.FlatStyle = FlatStyle.Flat;
        btnSearch.ForeColor = Color.Black;
        btnSearch.Image = (Image)resources.GetObject("btnSearch.Image");
        btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
        btnSearch.Location = new Point(585, 5);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(150, 40);
        btnSearch.TabIndex = 11;
        btnSearch.Text = "Pesquisar";
        btnSearch.TextColor = Color.Black;
        btnSearch.UseVisualStyleBackColor = false;
        btnSearch.Click += btnSearch_Click;
        // 
        // btnAdd
        // 
        btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnAdd.BackColor = Color.FromArgb(47, 125, 65);
        btnAdd.BackgroudColor = Color.FromArgb(47, 125, 65);
        btnAdd.BorderColor = Color.PaleVioletRed;
        btnAdd.BorderRadius = 40;
        btnAdd.BorderSize = 0;
        btnAdd.FlatAppearance.BorderSize = 0;
        btnAdd.FlatAppearance.MouseOverBackColor = Color.FromArgb(80, 212, 111);
        btnAdd.FlatStyle = FlatStyle.Flat;
        btnAdd.ForeColor = Color.Black;
        btnAdd.Image = (Image)resources.GetObject("btnAdd.Image");
        btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
        btnAdd.Location = new Point(741, 5);
        btnAdd.Name = "btnAdd";
        btnAdd.Size = new Size(150, 40);
        btnAdd.TabIndex = 10;
        btnAdd.Text = "Adicionar";
        btnAdd.TextColor = Color.Black;
        btnAdd.UseVisualStyleBackColor = false;
        btnAdd.Click += btnAdd_Click;
        // 
        // txtSearch
        // 
        txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
        txtSearch.BackColor = Color.White;
        txtSearch.BorderColor = Color.SpringGreen;
        txtSearch.BorderFocusColor = Color.SeaGreen;
        txtSearch.BorderSize = 2;
        txtSearch.Font = new Font("JetBrains Mono", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
        txtSearch.Location = new Point(9, 9);
        txtSearch.Margin = new Padding(4);
        txtSearch.MaximumSize = new Size(1000, 36);
        txtSearch.MaxLenght = 32767;
        txtSearch.MultLine = false;
        txtSearch.Name = "txtSearch";
        txtSearch.Padding = new Padding(7);
        txtSearch.PasswordChar = false;
        txtSearch.PlaceHolder = "Digite o nome do usuario";
        txtSearch.Size = new Size(531, 36);
        txtSearch.TabIndex = 9;
        txtSearch.Texts = "";
        txtSearch.UnderlineStyle = true;
        txtSearch._TextChanged += txtSearch__TextChanged;
        // 
        // dgvUsers
        // 
        dgvUsers.AllowUserToAddRows = false;
        dgvUsers.AllowUserToDeleteRows = false;
        dgvUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        dgvUsers.BackgroundColor = SystemColors.ControlLightLight;
        dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = SystemColors.Window;
        dataGridViewCellStyle1.Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
        dataGridViewCellStyle1.Padding = new Padding(5);
        dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
        dgvUsers.DefaultCellStyle = dataGridViewCellStyle1;
        dgvUsers.Location = new Point(5, 99);
        dgvUsers.Margin = new Padding(5);
        dgvUsers.MultiSelect = false;
        dgvUsers.Name = "dgvUsers";
        dgvUsers.ReadOnly = true;
        dgvUsers.ScrollBars = ScrollBars.Vertical;
        dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgvUsers.Size = new Size(905, 407);
        dgvUsers.TabIndex = 8;
        dgvUsers.DoubleClick += dgvUsers_DoubleClick;
        // 
        // tmrSearch
        // 
        tmrSearch.Interval = 900;
        tmrSearch.Tick += tmrSearch_Tick;
        // 
        // label1
        // 
        label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        label1.AutoSize = true;
        label1.Location = new Point(234, 63);
        label1.Name = "label1";
        label1.Size = new Size(344, 17);
        label1.TabIndex = 14;
        label1.Text = "Colocar Cores Melhores para esse botões ->";
        // 
        // frmUsers
        // 
        AutoScaleDimensions = new SizeF(8F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(915, 510);
        Controls.Add(btnDelete);
        Controls.Add(btnEdit);
        Controls.Add(btnSearch);
        Controls.Add(btnAdd);
        Controls.Add(txtSearch);
        Controls.Add(dgvUsers);
        Controls.Add(label1);
        Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.None;
        Name = "frmUsers";
        Padding = new Padding(5);
        Text = "frmUsers";
        ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private CustomControls.CustomButton btnDelete;
    private CustomControls.CustomButton btnEdit;
    private CustomControls.CustomButton btnSearch;
    private CustomControls.CustomButton btnAdd;
    private CustomControls.CustomTextBox txtSearch;
    private DataGridView dgvUsers;
    private System.Windows.Forms.Timer tmrSearch;
    private Label label1;
}
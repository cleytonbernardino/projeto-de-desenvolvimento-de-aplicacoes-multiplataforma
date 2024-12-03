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
        btnDelete = new CustomControls.CustomButton();
        btnEdit = new CustomControls.CustomButton();
        btnSearch = new CustomControls.CustomButton();
        btnAdd = new CustomControls.CustomButton();
        txtSearch = new CustomControls.CustomTextBox();
        tmrSearch = new System.Windows.Forms.Timer(components);
        ltvUsers = new ListView();
        chId = new ColumnHeader();
        chFirstName = new ColumnHeader();
        chLastName = new ColumnHeader();
        chCPF = new ColumnHeader();
        chBalance = new ColumnHeader();
        tmrAjustColun = new System.Windows.Forms.Timer(components);
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
        btnDelete.TabIndex = 5;
        btnDelete.TabStop = false;
        btnDelete.Text = "Apagar";
        btnDelete.TextColor = Color.Black;
        btnDelete.UseVisualStyleBackColor = false;
        btnDelete.Click += btnDelete_Click;
        // 
        // btnEdit
        // 
        btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnEdit.BackColor = Color.FromArgb(2, 184, 47);
        btnEdit.BackgroudColor = Color.FromArgb(2, 184, 47);
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
        btnEdit.TabIndex = 4;
        btnEdit.Text = "Editar";
        btnEdit.TextColor = Color.Black;
        btnEdit.UseVisualStyleBackColor = false;
        btnEdit.Click += btnEdit_Click;
        // 
        // btnSearch
        // 
        btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        btnSearch.BackColor = Color.FromArgb(93, 229, 245);
        btnSearch.BackgroudColor = Color.FromArgb(93, 229, 245);
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
        btnSearch.TabIndex = 2;
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
        btnAdd.TabIndex = 3;
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
        txtSearch.ReadOnly = false;
        txtSearch.Size = new Size(531, 36);
        txtSearch.TabIndex = 1;
        txtSearch.Texts = "";
        txtSearch.UnderlineStyle = true;
        txtSearch._TextChanged += txtSearch__TextChanged;
        // 
        // tmrSearch
        // 
        tmrSearch.Interval = 900;
        tmrSearch.Tick += tmrSearch_Tick;
        // 
        // ltvUsers
        // 
        ltvUsers.Activation = ItemActivation.TwoClick;
        ltvUsers.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        ltvUsers.Columns.AddRange(new ColumnHeader[] { chId, chFirstName, chLastName, chCPF, chBalance });
        ltvUsers.FullRowSelect = true;
        ltvUsers.GridLines = true;
        ltvUsers.Location = new Point(9, 107);
        ltvUsers.MultiSelect = false;
        ltvUsers.Name = "ltvUsers";
        ltvUsers.Size = new Size(898, 395);
        ltvUsers.TabIndex = 0;
        ltvUsers.UseCompatibleStateImageBehavior = false;
        ltvUsers.View = View.Details;
        ltvUsers.ItemActivate += ltvUsers_ItemActivate;
        // 
        // chId
        // 
        chId.Text = "ID";
        chId.Width = 103;
        // 
        // chFirstName
        // 
        chFirstName.Text = "Nome";
        chFirstName.Width = 240;
        // 
        // chLastName
        // 
        chLastName.Text = "Sobrenome";
        chLastName.Width = 240;
        // 
        // chCPF
        // 
        chCPF.Text = "CPF";
        chCPF.Width = 185;
        // 
        // chBalance
        // 
        chBalance.Text = "Saldo";
        chBalance.Width = 125;
        // 
        // tmrAjustColun
        // 
        tmrAjustColun.Enabled = true;
        tmrAjustColun.Tick += tmrAjustColun_Tick;
        // 
        // frmUsers
        // 
        AutoScaleDimensions = new SizeF(8F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(915, 510);
        Controls.Add(ltvUsers);
        Controls.Add(btnDelete);
        Controls.Add(btnEdit);
        Controls.Add(btnSearch);
        Controls.Add(btnAdd);
        Controls.Add(txtSearch);
        Font = new Font("JetBrains Mono", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.None;
        Name = "frmUsers";
        Padding = new Padding(5);
        Text = "frmUsers";
        ResumeLayout(false);
    }

    #endregion

    private CustomControls.CustomButton btnDelete;
    private CustomControls.CustomButton btnEdit;
    private CustomControls.CustomButton btnSearch;
    private CustomControls.CustomButton btnAdd;
    private CustomControls.CustomTextBox txtSearch;
    private System.Windows.Forms.Timer tmrSearch;
    private ListView ltvUsers;
    private ColumnHeader chId;
    private ColumnHeader chFirstName;
    private ColumnHeader chLastName;
    private ColumnHeader chCPF;
    private ColumnHeader chBalance;
    private System.Windows.Forms.Timer tmrAjustColun;
}
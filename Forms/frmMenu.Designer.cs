namespace ProjetoDesenvolvimentoAplicacoesMultplataforma;

partial class frmMenu
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
        pnlMenu = new Panel();
        btnAccounts = new Button();
        btnUser = new Button();
        btnVehicleList = new Button();
        pcbMain = new PictureBox();
        pnlTitle = new Panel();
        pcbMinimize = new PictureBox();
        pcbRestore = new PictureBox();
        pcbMaximize = new PictureBox();
        pcbClose = new PictureBox();
        pcbMenuIcon = new PictureBox();
        pnlFormContainer = new Panel();
        pnlMenu.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pcbMain).BeginInit();
        pnlTitle.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pcbMinimize).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pcbRestore).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pcbMaximize).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pcbClose).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pcbMenuIcon).BeginInit();
        SuspendLayout();
        // 
        // pnlMenu
        // 
        pnlMenu.BackColor = Color.FromArgb(1, 172, 75);
        pnlMenu.Controls.Add(btnAccounts);
        pnlMenu.Controls.Add(btnUser);
        pnlMenu.Controls.Add(btnVehicleList);
        pnlMenu.Controls.Add(pcbMain);
        pnlMenu.Dock = DockStyle.Left;
        pnlMenu.Location = new Point(0, 0);
        pnlMenu.Name = "pnlMenu";
        pnlMenu.Size = new Size(50, 681);
        pnlMenu.TabIndex = 0;
        // 
        // btnAccounts
        // 
        btnAccounts.Enabled = false;
        btnAccounts.FlatAppearance.BorderSize = 0;
        btnAccounts.FlatAppearance.MouseOverBackColor = SystemColors.ButtonShadow;
        btnAccounts.FlatStyle = FlatStyle.Flat;
        btnAccounts.Image = (Image)resources.GetObject("btnAccounts.Image");
        btnAccounts.ImageAlign = ContentAlignment.MiddleLeft;
        btnAccounts.Location = new Point(3, 284);
        btnAccounts.Name = "btnAccounts";
        btnAccounts.RightToLeft = RightToLeft.No;
        btnAccounts.Size = new Size(238, 57);
        btnAccounts.TabIndex = 3;
        btnAccounts.Text = "Gerenciar Contas";
        btnAccounts.UseVisualStyleBackColor = true;
        btnAccounts.Visible = false;
        // 
        // btnUser
        // 
        btnUser.FlatAppearance.BorderSize = 0;
        btnUser.FlatAppearance.MouseOverBackColor = SystemColors.ButtonShadow;
        btnUser.FlatStyle = FlatStyle.Flat;
        btnUser.Image = (Image)resources.GetObject("btnUser.Image");
        btnUser.ImageAlign = ContentAlignment.MiddleLeft;
        btnUser.Location = new Point(6, 221);
        btnUser.Name = "btnUser";
        btnUser.RightToLeft = RightToLeft.No;
        btnUser.Size = new Size(238, 57);
        btnUser.TabIndex = 2;
        btnUser.Text = "Usuarios";
        btnUser.UseVisualStyleBackColor = true;
        btnUser.Click += btnUser_Click;
        // 
        // btnVehicleList
        // 
        btnVehicleList.FlatAppearance.BorderSize = 0;
        btnVehicleList.FlatAppearance.MouseOverBackColor = SystemColors.ButtonShadow;
        btnVehicleList.FlatStyle = FlatStyle.Flat;
        btnVehicleList.Image = (Image)resources.GetObject("btnVehicleList.Image");
        btnVehicleList.ImageAlign = ContentAlignment.MiddleLeft;
        btnVehicleList.Location = new Point(6, 158);
        btnVehicleList.Name = "btnVehicleList";
        btnVehicleList.RightToLeft = RightToLeft.No;
        btnVehicleList.Size = new Size(238, 57);
        btnVehicleList.TabIndex = 1;
        btnVehicleList.Text = "Carros";
        btnVehicleList.UseVisualStyleBackColor = true;
        btnVehicleList.Click += btnVehicleList_Click;
        // 
        // pcbMain
        // 
        pcbMain.Cursor = Cursors.Hand;
        pcbMain.Image = (Image)resources.GetObject("pcbMain.Image");
        pcbMain.Location = new Point(6, 6);
        pcbMain.Name = "pcbMain";
        pcbMain.Size = new Size(241, 95);
        pcbMain.SizeMode = PictureBoxSizeMode.Zoom;
        pcbMain.TabIndex = 0;
        pcbMain.TabStop = false;
        pcbMain.Click += pcbMain_Click;
        // 
        // pnlTitle
        // 
        pnlTitle.Controls.Add(pcbMinimize);
        pnlTitle.Controls.Add(pcbRestore);
        pnlTitle.Controls.Add(pcbMaximize);
        pnlTitle.Controls.Add(pcbClose);
        pnlTitle.Controls.Add(pcbMenuIcon);
        pnlTitle.Dock = DockStyle.Top;
        pnlTitle.Location = new Point(50, 0);
        pnlTitle.Name = "pnlTitle";
        pnlTitle.Size = new Size(1214, 40);
        pnlTitle.TabIndex = 1;
        pnlTitle.MouseDown += pnlTitle_MouseDown;
        // 
        // pcbMinimize
        // 
        pcbMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        pcbMinimize.BackgroundImage = (Image)resources.GetObject("pcbMinimize.BackgroundImage");
        pcbMinimize.Cursor = Cursors.Hand;
        pcbMinimize.Location = new Point(1094, 3);
        pcbMinimize.Name = "pcbMinimize";
        pcbMinimize.Size = new Size(32, 32);
        pcbMinimize.TabIndex = 4;
        pcbMinimize.TabStop = false;
        pcbMinimize.Click += pcbMinimize_Click;
        // 
        // pcbRestore
        // 
        pcbRestore.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        pcbRestore.BackgroundImage = (Image)resources.GetObject("pcbRestore.BackgroundImage");
        pcbRestore.Cursor = Cursors.Hand;
        pcbRestore.Location = new Point(1132, 3);
        pcbRestore.Name = "pcbRestore";
        pcbRestore.Size = new Size(32, 32);
        pcbRestore.TabIndex = 3;
        pcbRestore.TabStop = false;
        pcbRestore.Visible = false;
        pcbRestore.Click += pcbRestore_Click;
        // 
        // pcbMaximize
        // 
        pcbMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        pcbMaximize.BackgroundImage = (Image)resources.GetObject("pcbMaximize.BackgroundImage");
        pcbMaximize.Cursor = Cursors.Hand;
        pcbMaximize.Location = new Point(1132, 3);
        pcbMaximize.Name = "pcbMaximize";
        pcbMaximize.Size = new Size(32, 32);
        pcbMaximize.TabIndex = 2;
        pcbMaximize.TabStop = false;
        pcbMaximize.Click += pcbMaximize_Click;
        // 
        // pcbClose
        // 
        pcbClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        pcbClose.BackgroundImage = (Image)resources.GetObject("pcbClose.BackgroundImage");
        pcbClose.Cursor = Cursors.Hand;
        pcbClose.Location = new Point(1170, 3);
        pcbClose.Name = "pcbClose";
        pcbClose.Size = new Size(32, 32);
        pcbClose.TabIndex = 1;
        pcbClose.TabStop = false;
        pcbClose.Click += pcbClose_Click;
        // 
        // pcbMenuIcon
        // 
        pcbMenuIcon.Cursor = Cursors.Hand;
        pcbMenuIcon.Image = (Image)resources.GetObject("pcbMenuIcon.Image");
        pcbMenuIcon.Location = new Point(6, 3);
        pcbMenuIcon.Name = "pcbMenuIcon";
        pcbMenuIcon.Size = new Size(32, 32);
        pcbMenuIcon.TabIndex = 0;
        pcbMenuIcon.TabStop = false;
        pcbMenuIcon.Click += pcbMenuIcon_Click;
        // 
        // pnlFormContainer
        // 
        pnlFormContainer.BackgroundImage = (Image)resources.GetObject("pnlFormContainer.BackgroundImage");
        pnlFormContainer.BackgroundImageLayout = ImageLayout.Zoom;
        pnlFormContainer.Dock = DockStyle.Fill;
        pnlFormContainer.Location = new Point(50, 40);
        pnlFormContainer.Name = "pnlFormContainer";
        pnlFormContainer.Size = new Size(1214, 641);
        pnlFormContainer.TabIndex = 2;
        // 
        // frmMenu
        // 
        AutoScaleMode = AutoScaleMode.None;
        BackColor = SystemColors.Window;
        ClientSize = new Size(1264, 681);
        Controls.Add(pnlFormContainer);
        Controls.Add(pnlTitle);
        Controls.Add(pnlMenu);
        Font = new Font("JetBrains Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.None;
        Icon = (Icon)resources.GetObject("$this.Icon");
        Name = "frmMenu";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "we";
        pnlMenu.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pcbMain).EndInit();
        pnlTitle.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pcbMinimize).EndInit();
        ((System.ComponentModel.ISupportInitialize)pcbRestore).EndInit();
        ((System.ComponentModel.ISupportInitialize)pcbMaximize).EndInit();
        ((System.ComponentModel.ISupportInitialize)pcbClose).EndInit();
        ((System.ComponentModel.ISupportInitialize)pcbMenuIcon).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Panel pnlMenu;
    private Panel pnlTitle;
    private Panel pnlFormContainer;
    private PictureBox pcbMenuIcon;
    private PictureBox pcbClose;
    private PictureBox pcbMinimize;
    private PictureBox pcbRestore;
    private PictureBox pcbMaximize;
    private PictureBox pcbMain;
    private Button btnVehicleList;
    private Button btnUser;
    private Button btnAccounts;
}
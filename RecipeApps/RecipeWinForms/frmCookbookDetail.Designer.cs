namespace RecipeWinForms
{
    partial class frmCookbookDetail
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
            tblMain = new TableLayoutPanel();
            tblRecipe = new TableLayoutPanel();
            gRecipe = new DataGridView();
            btnSaveRecipe = new Button();
            btnSaveCookbook = new Button();
            btnDelete = new Button();
            lblCaptionCookbookName = new Label();
            lblCaptionUser = new Label();
            lblCaptionPrice = new Label();
            lblCaptionActive = new Label();
            lstUserName = new ComboBox();
            chkCookbookStatus = new CheckBox();
            tblPrice = new TableLayoutPanel();
            lblCaptionDateCreated = new Label();
            txtCookbookPrice = new TextBox();
            lblDateCreated = new Label();
            txtCookbookName = new TextBox();
            tblMain.SuspendLayout();
            tblRecipe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipe).BeginInit();
            tblPrice.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.Controls.Add(tblRecipe, 0, 6);
            tblMain.Controls.Add(btnSaveCookbook, 0, 0);
            tblMain.Controls.Add(btnDelete, 1, 0);
            tblMain.Controls.Add(lblCaptionCookbookName, 0, 1);
            tblMain.Controls.Add(lblCaptionUser, 0, 2);
            tblMain.Controls.Add(lblCaptionPrice, 0, 4);
            tblMain.Controls.Add(lblCaptionActive, 0, 5);
            tblMain.Controls.Add(lstUserName, 1, 2);
            tblMain.Controls.Add(chkCookbookStatus, 1, 5);
            tblMain.Controls.Add(tblPrice, 1, 3);
            tblMain.Controls.Add(txtCookbookName, 1, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 7;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 57F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 69F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 13.1465521F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 86.85345F));
            tblMain.Size = new Size(656, 761);
            tblMain.TabIndex = 0;
            // 
            // tblRecipe
            // 
            tblRecipe.ColumnCount = 1;
            tblMain.SetColumnSpan(tblRecipe, 2);
            tblRecipe.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblRecipe.Controls.Add(gRecipe, 0, 1);
            tblRecipe.Controls.Add(btnSaveRecipe, 0, 0);
            tblRecipe.Dock = DockStyle.Fill;
            tblRecipe.Location = new Point(3, 361);
            tblRecipe.Name = "tblRecipe";
            tblRecipe.RowCount = 2;
            tblRecipe.RowStyles.Add(new RowStyle(SizeType.Percent, 22.9219151F));
            tblRecipe.RowStyles.Add(new RowStyle(SizeType.Percent, 77.07809F));
            tblRecipe.Size = new Size(650, 397);
            tblRecipe.TabIndex = 13;
            // 
            // gRecipe
            // 
            gRecipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gRecipe.Dock = DockStyle.Fill;
            gRecipe.Location = new Point(3, 94);
            gRecipe.Name = "gRecipe";
            gRecipe.RowHeadersWidth = 51;
            gRecipe.Size = new Size(644, 300);
            gRecipe.TabIndex = 14;
            // 
            // btnSaveRecipe
            // 
            btnSaveRecipe.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnSaveRecipe.AutoSize = true;
            btnSaveRecipe.Location = new Point(3, 50);
            btnSaveRecipe.Name = "btnSaveRecipe";
            btnSaveRecipe.Size = new Size(94, 38);
            btnSaveRecipe.TabIndex = 15;
            btnSaveRecipe.Text = "Save";
            btnSaveRecipe.UseVisualStyleBackColor = true;
            // 
            // btnSaveCookbook
            // 
            btnSaveCookbook.AutoSize = true;
            btnSaveCookbook.Location = new Point(3, 3);
            btnSaveCookbook.Name = "btnSaveCookbook";
            btnSaveCookbook.Size = new Size(94, 38);
            btnSaveCookbook.TabIndex = 11;
            btnSaveCookbook.Text = "Save";
            btnSaveCookbook.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.Location = new Point(170, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 38);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblCaptionCookbookName
            // 
            lblCaptionCookbookName.AutoSize = true;
            lblCaptionCookbookName.Dock = DockStyle.Fill;
            lblCaptionCookbookName.Location = new Point(3, 53);
            lblCaptionCookbookName.Name = "lblCaptionCookbookName";
            lblCaptionCookbookName.Size = new Size(161, 57);
            lblCaptionCookbookName.TabIndex = 0;
            lblCaptionCookbookName.Text = "Cookbook Name";
            lblCaptionCookbookName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCaptionUser
            // 
            lblCaptionUser.AutoSize = true;
            lblCaptionUser.Dock = DockStyle.Fill;
            lblCaptionUser.Location = new Point(3, 110);
            lblCaptionUser.Name = "lblCaptionUser";
            lblCaptionUser.Size = new Size(161, 54);
            lblCaptionUser.TabIndex = 2;
            lblCaptionUser.Text = "User";
            lblCaptionUser.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCaptionPrice
            // 
            lblCaptionPrice.AutoSize = true;
            lblCaptionPrice.Dock = DockStyle.Fill;
            lblCaptionPrice.Location = new Point(3, 228);
            lblCaptionPrice.Name = "lblCaptionPrice";
            lblCaptionPrice.Size = new Size(161, 69);
            lblCaptionPrice.TabIndex = 4;
            lblCaptionPrice.Text = "Price";
            lblCaptionPrice.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCaptionActive
            // 
            lblCaptionActive.AutoSize = true;
            lblCaptionActive.Dock = DockStyle.Fill;
            lblCaptionActive.Location = new Point(3, 297);
            lblCaptionActive.Name = "lblCaptionActive";
            lblCaptionActive.Size = new Size(161, 61);
            lblCaptionActive.TabIndex = 9;
            lblCaptionActive.Text = "Active";
            lblCaptionActive.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lstUserName
            // 
            lstUserName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(170, 123);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(483, 36);
            lstUserName.TabIndex = 3;
            // 
            // chkCookbookStatus
            // 
            chkCookbookStatus.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            chkCookbookStatus.AutoSize = true;
            chkCookbookStatus.Location = new Point(170, 319);
            chkCookbookStatus.Name = "chkCookbookStatus";
            chkCookbookStatus.Size = new Size(483, 17);
            chkCookbookStatus.TabIndex = 10;
            chkCookbookStatus.UseVisualStyleBackColor = true;
            // 
            // tblPrice
            // 
            tblPrice.ColumnCount = 2;
            tblPrice.ColumnStyles.Add(new ColumnStyle());
            tblPrice.ColumnStyles.Add(new ColumnStyle());
            tblPrice.Controls.Add(lblCaptionDateCreated, 1, 0);
            tblPrice.Controls.Add(txtCookbookPrice, 0, 1);
            tblPrice.Controls.Add(lblDateCreated, 1, 1);
            tblPrice.Dock = DockStyle.Fill;
            tblPrice.Location = new Point(170, 167);
            tblPrice.Name = "tblPrice";
            tblPrice.RowCount = 2;
            tblMain.SetRowSpan(tblPrice, 2);
            tblPrice.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblPrice.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblPrice.Size = new Size(483, 127);
            tblPrice.TabIndex = 5;
            // 
            // lblCaptionDateCreated
            // 
            lblCaptionDateCreated.AutoSize = true;
            lblCaptionDateCreated.Dock = DockStyle.Fill;
            lblCaptionDateCreated.Location = new Point(319, 0);
            lblCaptionDateCreated.Name = "lblCaptionDateCreated";
            lblCaptionDateCreated.Size = new Size(161, 63);
            lblCaptionDateCreated.TabIndex = 7;
            lblCaptionDateCreated.Text = "Date Created";
            lblCaptionDateCreated.TextAlign = ContentAlignment.BottomCenter;
            // 
            // txtCookbookPrice
            // 
            txtCookbookPrice.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCookbookPrice.Location = new Point(3, 78);
            txtCookbookPrice.Name = "txtCookbookPrice";
            txtCookbookPrice.Size = new Size(310, 34);
            txtCookbookPrice.TabIndex = 6;
            // 
            // lblDateCreated
            // 
            lblDateCreated.AutoSize = true;
            lblDateCreated.Dock = DockStyle.Fill;
            lblDateCreated.Location = new Point(319, 63);
            lblDateCreated.Name = "lblDateCreated";
            lblDateCreated.Size = new Size(161, 64);
            lblDateCreated.TabIndex = 8;
            lblDateCreated.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCookbookName
            // 
            txtCookbookName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCookbookName.Location = new Point(170, 64);
            txtCookbookName.Name = "txtCookbookName";
            txtCookbookName.Size = new Size(483, 34);
            txtCookbookName.TabIndex = 1;
            // 
            // frmCookbookDetail
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 761);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmCookbookDetail";
            Text = "Cookbook Detail";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblRecipe.ResumeLayout(false);
            tblRecipe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipe).EndInit();
            tblPrice.ResumeLayout(false);
            tblPrice.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblRecipe;
        private DataGridView gRecipe;
        private Button btnSaveRecipe;
        private Button btnSaveCookbook;
        private Button btnDelete;
        private Label lblCaptionCookbookName;
        private Label lblCaptionUser;
        private Label lblCaptionPrice;
        private Label lblCaptionActive;
        private ComboBox lstUserName;
        private CheckBox chkCookbookStatus;
        private TableLayoutPanel tblPrice;
        private Label lblCaptionDateCreated;
        private TextBox txtCookbookPrice;
        private TextBox txtCookbookName;
        private Label lblDateCreated;
    }
}
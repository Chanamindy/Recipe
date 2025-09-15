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
            dtpDateCreated = new DateTimePicker();
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
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.2682915F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.73171F));
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
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
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
            tblRecipe.RowStyles.Add(new RowStyle(SizeType.Percent, 16.2666664F));
            tblRecipe.RowStyles.Add(new RowStyle(SizeType.Percent, 83.73333F));
            tblRecipe.Size = new Size(650, 397);
            tblRecipe.TabIndex = 0;
            // 
            // gRecipe
            // 
            gRecipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gRecipe.Dock = DockStyle.Fill;
            gRecipe.Location = new Point(3, 67);
            gRecipe.Name = "gRecipe";
            gRecipe.RowHeadersWidth = 51;
            gRecipe.Size = new Size(644, 327);
            gRecipe.TabIndex = 0;
            // 
            // btnSaveRecipe
            // 
            btnSaveRecipe.AutoSize = true;
            btnSaveRecipe.Location = new Point(3, 3);
            btnSaveRecipe.Name = "btnSaveRecipe";
            btnSaveRecipe.Size = new Size(94, 38);
            btnSaveRecipe.TabIndex = 1;
            btnSaveRecipe.Text = "Save";
            btnSaveRecipe.UseVisualStyleBackColor = true;
            // 
            // btnSaveCookbook
            // 
            btnSaveCookbook.AutoSize = true;
            btnSaveCookbook.Location = new Point(3, 3);
            btnSaveCookbook.Name = "btnSaveCookbook";
            btnSaveCookbook.Size = new Size(94, 38);
            btnSaveCookbook.TabIndex = 1;
            btnSaveCookbook.Text = "Save";
            btnSaveCookbook.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.Location = new Point(195, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 38);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblCaptionCookbookName
            // 
            lblCaptionCookbookName.AutoSize = true;
            lblCaptionCookbookName.Location = new Point(3, 53);
            lblCaptionCookbookName.Name = "lblCaptionCookbookName";
            lblCaptionCookbookName.Size = new Size(161, 28);
            lblCaptionCookbookName.TabIndex = 0;
            lblCaptionCookbookName.Text = "Cookbook Name";
            // 
            // lblCaptionUser
            // 
            lblCaptionUser.AutoSize = true;
            lblCaptionUser.Location = new Point(3, 110);
            lblCaptionUser.Name = "lblCaptionUser";
            lblCaptionUser.Size = new Size(51, 28);
            lblCaptionUser.TabIndex = 2;
            lblCaptionUser.Text = "User";
            // 
            // lblCaptionPrice
            // 
            lblCaptionPrice.AutoSize = true;
            lblCaptionPrice.Location = new Point(3, 228);
            lblCaptionPrice.Name = "lblCaptionPrice";
            lblCaptionPrice.Size = new Size(54, 28);
            lblCaptionPrice.TabIndex = 4;
            lblCaptionPrice.Text = "Price";
            // 
            // lblCaptionActive
            // 
            lblCaptionActive.AutoSize = true;
            lblCaptionActive.Location = new Point(3, 297);
            lblCaptionActive.Name = "lblCaptionActive";
            lblCaptionActive.Size = new Size(66, 28);
            lblCaptionActive.TabIndex = 5;
            lblCaptionActive.Text = "Active";
            // 
            // lstUserName
            // 
            lstUserName.Dock = DockStyle.Fill;
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(195, 113);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(458, 36);
            lstUserName.TabIndex = 3;
            // 
            // chkCookbookStatus
            // 
            chkCookbookStatus.AutoSize = true;
            chkCookbookStatus.Location = new Point(195, 300);
            chkCookbookStatus.Name = "chkCookbookStatus";
            chkCookbookStatus.Size = new Size(18, 17);
            chkCookbookStatus.TabIndex = 6;
            chkCookbookStatus.UseVisualStyleBackColor = true;
            // 
            // tblPrice
            // 
            tblPrice.ColumnCount = 3;
            tblPrice.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.7931023F));
            tblPrice.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.2068977F));
            tblPrice.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 167F));
            tblPrice.Controls.Add(lblCaptionDateCreated, 2, 0);
            tblPrice.Controls.Add(txtCookbookPrice, 0, 1);
            tblPrice.Controls.Add(dtpDateCreated, 2, 1);
            tblPrice.Dock = DockStyle.Fill;
            tblPrice.Location = new Point(195, 167);
            tblPrice.Name = "tblPrice";
            tblPrice.RowCount = 2;
            tblMain.SetRowSpan(tblPrice, 2);
            tblPrice.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblPrice.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblPrice.Size = new Size(458, 127);
            tblPrice.TabIndex = 10;
            // 
            // lblCaptionDateCreated
            // 
            lblCaptionDateCreated.AutoSize = true;
            lblCaptionDateCreated.Location = new Point(293, 0);
            lblCaptionDateCreated.Name = "lblCaptionDateCreated";
            lblCaptionDateCreated.Size = new Size(126, 28);
            lblCaptionDateCreated.TabIndex = 2;
            lblCaptionDateCreated.Text = "Date Created";
            // 
            // txtCookbookPrice
            // 
            txtCookbookPrice.Dock = DockStyle.Fill;
            txtCookbookPrice.Location = new Point(3, 66);
            txtCookbookPrice.Name = "txtCookbookPrice";
            txtCookbookPrice.Size = new Size(179, 34);
            txtCookbookPrice.TabIndex = 0;
            // 
            // dtpDateCreated
            // 
            dtpDateCreated.Format = DateTimePickerFormat.Short;
            dtpDateCreated.Location = new Point(293, 66);
            dtpDateCreated.Name = "dtpDateCreated";
            dtpDateCreated.Size = new Size(162, 34);
            dtpDateCreated.TabIndex = 1;
            // 
            // txtCookbookName
            // 
            txtCookbookName.Dock = DockStyle.Fill;
            txtCookbookName.Location = new Point(195, 56);
            txtCookbookName.Name = "txtCookbookName";
            txtCookbookName.Size = new Size(458, 34);
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
        private DateTimePicker dtpDateCreated;
    }
}
namespace RecipeWinForms
{
    partial class frmRecipeDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecipeDetail));
            tblMain = new TableLayoutPanel();
            lblCaptionRecipeName = new Label();
            lblCaptionCuisineType = new Label();
            lblCaptionCalorie = new Label();
            lblCaptionUserFirstName = new Label();
            lblCaptionUserLastName = new Label();
            lblCaptionDateDrafted = new Label();
            lblCaptionDatePublished = new Label();
            lblCaptionDateArchived = new Label();
            lblCaptionRecipeStatus = new Label();
            lblDatePublished = new Label();
            lblDateArchived = new Label();
            txtCalorie = new TextBox();
            lstCuisineType = new ComboBox();
            txtRecipeName = new TextBox();
            lstUserFirstName = new ComboBox();
            lstUserLastName = new ComboBox();
            lblRecipeStatus = new Label();
            tsMain = new ToolStrip();
            btnSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnDelete = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            dtpDateDrafted = new DateTimePicker();
            tblMain.SuspendLayout();
            tsMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.44961F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.55039F));
            tblMain.Controls.Add(lblCaptionRecipeName, 0, 0);
            tblMain.Controls.Add(lblCaptionCuisineType, 0, 1);
            tblMain.Controls.Add(lblCaptionCalorie, 0, 2);
            tblMain.Controls.Add(lblCaptionUserFirstName, 0, 3);
            tblMain.Controls.Add(lblCaptionUserLastName, 0, 4);
            tblMain.Controls.Add(lblCaptionDateDrafted, 0, 5);
            tblMain.Controls.Add(lblCaptionDatePublished, 0, 6);
            tblMain.Controls.Add(lblCaptionDateArchived, 0, 7);
            tblMain.Controls.Add(lblCaptionRecipeStatus, 0, 8);
            tblMain.Controls.Add(lblDatePublished, 1, 6);
            tblMain.Controls.Add(lblDateArchived, 1, 7);
            tblMain.Controls.Add(txtCalorie, 1, 2);
            tblMain.Controls.Add(lstCuisineType, 1, 1);
            tblMain.Controls.Add(txtRecipeName, 1, 0);
            tblMain.Controls.Add(lstUserFirstName, 1, 3);
            tblMain.Controls.Add(lstUserLastName, 1, 4);
            tblMain.Controls.Add(lblRecipeStatus, 1, 8);
            tblMain.Controls.Add(dtpDateDrafted, 1, 5);
            tblMain.Location = new Point(0, 51);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 9;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(623, 579);
            tblMain.TabIndex = 0;
            // 
            // lblCaptionRecipeName
            // 
            lblCaptionRecipeName.Anchor = AnchorStyles.Left;
            lblCaptionRecipeName.AutoSize = true;
            lblCaptionRecipeName.Location = new Point(4, 6);
            lblCaptionRecipeName.Margin = new Padding(4, 0, 4, 0);
            lblCaptionRecipeName.Name = "lblCaptionRecipeName";
            lblCaptionRecipeName.Size = new Size(126, 28);
            lblCaptionRecipeName.TabIndex = 0;
            lblCaptionRecipeName.Text = "Recipe Name";
            // 
            // lblCaptionCuisineType
            // 
            lblCaptionCuisineType.Anchor = AnchorStyles.Left;
            lblCaptionCuisineType.AutoSize = true;
            lblCaptionCuisineType.Location = new Point(4, 47);
            lblCaptionCuisineType.Margin = new Padding(4, 0, 4, 0);
            lblCaptionCuisineType.Name = "lblCaptionCuisineType";
            lblCaptionCuisineType.Size = new Size(120, 28);
            lblCaptionCuisineType.TabIndex = 1;
            lblCaptionCuisineType.Text = "Cuisine Type";
            // 
            // lblCaptionCalorie
            // 
            lblCaptionCalorie.Anchor = AnchorStyles.Left;
            lblCaptionCalorie.AutoSize = true;
            lblCaptionCalorie.Location = new Point(4, 88);
            lblCaptionCalorie.Margin = new Padding(4, 0, 4, 0);
            lblCaptionCalorie.Name = "lblCaptionCalorie";
            lblCaptionCalorie.Size = new Size(73, 28);
            lblCaptionCalorie.TabIndex = 2;
            lblCaptionCalorie.Text = "Calorie";
            // 
            // lblCaptionUserFirstName
            // 
            lblCaptionUserFirstName.Anchor = AnchorStyles.Left;
            lblCaptionUserFirstName.AutoSize = true;
            lblCaptionUserFirstName.Location = new Point(4, 129);
            lblCaptionUserFirstName.Margin = new Padding(4, 0, 4, 0);
            lblCaptionUserFirstName.Name = "lblCaptionUserFirstName";
            lblCaptionUserFirstName.Size = new Size(150, 28);
            lblCaptionUserFirstName.TabIndex = 3;
            lblCaptionUserFirstName.Text = "User First Name";
            // 
            // lblCaptionUserLastName
            // 
            lblCaptionUserLastName.Anchor = AnchorStyles.Left;
            lblCaptionUserLastName.AutoSize = true;
            lblCaptionUserLastName.Location = new Point(4, 171);
            lblCaptionUserLastName.Margin = new Padding(4, 0, 4, 0);
            lblCaptionUserLastName.Name = "lblCaptionUserLastName";
            lblCaptionUserLastName.Size = new Size(147, 28);
            lblCaptionUserLastName.TabIndex = 4;
            lblCaptionUserLastName.Text = "User Last Name";
            // 
            // lblCaptionDateDrafted
            // 
            lblCaptionDateDrafted.Anchor = AnchorStyles.Left;
            lblCaptionDateDrafted.AutoSize = true;
            lblCaptionDateDrafted.Location = new Point(4, 212);
            lblCaptionDateDrafted.Margin = new Padding(4, 0, 4, 0);
            lblCaptionDateDrafted.Name = "lblCaptionDateDrafted";
            lblCaptionDateDrafted.Size = new Size(124, 28);
            lblCaptionDateDrafted.TabIndex = 5;
            lblCaptionDateDrafted.Text = "Date Drafted";
            // 
            // lblCaptionDatePublished
            // 
            lblCaptionDatePublished.Anchor = AnchorStyles.Left;
            lblCaptionDatePublished.AutoSize = true;
            lblCaptionDatePublished.Location = new Point(4, 246);
            lblCaptionDatePublished.Margin = new Padding(4, 0, 4, 0);
            lblCaptionDatePublished.Name = "lblCaptionDatePublished";
            lblCaptionDatePublished.Size = new Size(143, 28);
            lblCaptionDatePublished.TabIndex = 6;
            lblCaptionDatePublished.Text = "Date Published";
            // 
            // lblCaptionDateArchived
            // 
            lblCaptionDateArchived.Anchor = AnchorStyles.Left;
            lblCaptionDateArchived.AutoSize = true;
            lblCaptionDateArchived.Location = new Point(4, 274);
            lblCaptionDateArchived.Margin = new Padding(4, 0, 4, 0);
            lblCaptionDateArchived.Name = "lblCaptionDateArchived";
            lblCaptionDateArchived.Size = new Size(135, 28);
            lblCaptionDateArchived.TabIndex = 7;
            lblCaptionDateArchived.Text = "Date Archived";
            // 
            // lblCaptionRecipeStatus
            // 
            lblCaptionRecipeStatus.AutoSize = true;
            lblCaptionRecipeStatus.Location = new Point(4, 302);
            lblCaptionRecipeStatus.Margin = new Padding(4, 0, 4, 0);
            lblCaptionRecipeStatus.Name = "lblCaptionRecipeStatus";
            lblCaptionRecipeStatus.Size = new Size(127, 28);
            lblCaptionRecipeStatus.TabIndex = 8;
            lblCaptionRecipeStatus.Text = "Recipe Status";
            // 
            // lblDatePublished
            // 
            lblDatePublished.AutoSize = true;
            lblDatePublished.BackColor = Color.WhiteSmoke;
            lblDatePublished.Dock = DockStyle.Fill;
            lblDatePublished.Location = new Point(242, 246);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(378, 28);
            lblDatePublished.TabIndex = 15;
            // 
            // lblDateArchived
            // 
            lblDateArchived.AutoSize = true;
            lblDateArchived.BackColor = Color.WhiteSmoke;
            lblDateArchived.Dock = DockStyle.Fill;
            lblDateArchived.Location = new Point(242, 274);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(378, 28);
            lblDateArchived.TabIndex = 16;
            // 
            // txtCalorie
            // 
            txtCalorie.Dock = DockStyle.Fill;
            txtCalorie.Location = new Point(242, 85);
            txtCalorie.Name = "txtCalorie";
            txtCalorie.Size = new Size(378, 34);
            txtCalorie.TabIndex = 21;
            // 
            // lstCuisineType
            // 
            lstCuisineType.FormattingEnabled = true;
            lstCuisineType.Location = new Point(242, 43);
            lstCuisineType.Name = "lstCuisineType";
            lstCuisineType.Size = new Size(173, 36);
            lstCuisineType.TabIndex = 22;
            // 
            // txtRecipeName
            // 
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Location = new Point(242, 3);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(378, 34);
            txtRecipeName.TabIndex = 23;
            // 
            // lstUserFirstName
            // 
            lstUserFirstName.FormattingEnabled = true;
            lstUserFirstName.Location = new Point(242, 125);
            lstUserFirstName.Name = "lstUserFirstName";
            lstUserFirstName.Size = new Size(173, 36);
            lstUserFirstName.TabIndex = 24;
            // 
            // lstUserLastName
            // 
            lstUserLastName.FormattingEnabled = true;
            lstUserLastName.Location = new Point(242, 167);
            lstUserLastName.Name = "lstUserLastName";
            lstUserLastName.Size = new Size(173, 36);
            lstUserLastName.TabIndex = 25;
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.AutoSize = true;
            lblRecipeStatus.Dock = DockStyle.Fill;
            lblRecipeStatus.Location = new Point(242, 302);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(378, 277);
            lblRecipeStatus.TabIndex = 26;
            // 
            // tsMain
            // 
            tsMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tsMain.ImageScalingSize = new Size(20, 20);
            tsMain.Items.AddRange(new ToolStripItem[] { btnSave, toolStripSeparator1, btnDelete, toolStripSeparator2 });
            tsMain.Location = new Point(0, 0);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(624, 35);
            tsMain.TabIndex = 1;
            tsMain.Text = "toolStrip1";
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(57, 32);
            btnSave.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 35);
            // 
            // btnDelete
            // 
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(72, 32);
            btnDelete.Text = "Delete";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 35);
            // 
            // dtpDateDrafted
            // 
            dtpDateDrafted.Format = DateTimePickerFormat.Short;
            dtpDateDrafted.Location = new Point(242, 209);
            dtpDateDrafted.Name = "dtpDateDrafted";
            dtpDateDrafted.Size = new Size(173, 34);
            dtpDateDrafted.TabIndex = 27;
            // 
            // frmRecipeDetail
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 633);
            Controls.Add(tsMain);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmRecipeDetail";
            Text = "frmRecipeDetail";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tsMain.ResumeLayout(false);
            tsMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCaptionRecipeName;
        private Label lblCaptionCuisineType;
        private Label lblCaptionCalorie;
        private Label lblCaptionUserFirstName;
        private Label lblCaptionUserLastName;
        private Label lblCaptionDateDrafted;
        private Label lblCaptionDatePublished;
        private Label lblCaptionDateArchived;
        private Label lblCaptionRecipeStatus;
        private Label lblDatePublished;
        private Label lblDateArchived;
        private TextBox txtCalorie;
        private ComboBox lstCuisineType;
        private TextBox txtRecipeName;
        private ComboBox lstUserFirstName;
        private ComboBox lstUserLastName;
        private ToolStrip tsMain;
        private ToolStripButton btnSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnDelete;
        private ToolStripSeparator toolStripSeparator2;
        private Label lblRecipeStatus;
        private DateTimePicker dtpDateDrafted;
    }
}
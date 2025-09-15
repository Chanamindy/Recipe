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
            tblMain = new TableLayoutPanel();
            lblCaptionRecipeName = new Label();
            txtRecipeName = new TextBox();
            lblCaptionUserFirstName = new Label();
            lstUserName = new ComboBox();
            lblCaptionCuisineType = new Label();
            lstCuisineType = new ComboBox();
            lblCaptionCalorie = new Label();
            txtCalorie = new TextBox();
            lblCaptionRecipeStatus = new Label();
            lblRecipeStatus = new Label();
            tblStatusDates = new TableLayoutPanel();
            lblCaptionDateDrafted = new Label();
            lblCaptionDateArchived = new Label();
            lblCaptionDatePublished = new Label();
            lblDateDrafted = new Label();
            lblDatePublished = new Label();
            lblDateArchived = new Label();
            lblStatusDates = new Label();
            tbRecipe = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            gRecipeIngredient = new DataGridView();
            btnSaveRecipeIngredient = new Button();
            tabPage2 = new TabPage();
            tblRecipeDirection = new TableLayoutPanel();
            gRecipeDirection = new DataGridView();
            btnSaveRecipeDirection = new Button();
            tblButtons = new TableLayoutPanel();
            btnSave = new Button();
            btnDelete = new Button();
            btnChangeStatus = new Button();
            tblMain.SuspendLayout();
            tblStatusDates.SuspendLayout();
            tbRecipe.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipeIngredient).BeginInit();
            tabPage2.SuspendLayout();
            tblRecipeDirection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipeDirection).BeginInit();
            tblButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.44961F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.55039F));
            tblMain.Controls.Add(lblCaptionRecipeName, 0, 1);
            tblMain.Controls.Add(txtRecipeName, 1, 1);
            tblMain.Controls.Add(lblCaptionUserFirstName, 0, 2);
            tblMain.Controls.Add(lstUserName, 1, 2);
            tblMain.Controls.Add(lblCaptionCuisineType, 0, 3);
            tblMain.Controls.Add(lstCuisineType, 1, 3);
            tblMain.Controls.Add(lblCaptionCalorie, 0, 4);
            tblMain.Controls.Add(txtCalorie, 1, 4);
            tblMain.Controls.Add(lblCaptionRecipeStatus, 0, 5);
            tblMain.Controls.Add(lblRecipeStatus, 1, 5);
            tblMain.Controls.Add(tblStatusDates, 1, 7);
            tblMain.Controls.Add(lblStatusDates, 0, 8);
            tblMain.Controls.Add(tbRecipe, 0, 9);
            tblMain.Controls.Add(tblButtons, 0, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 10;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tblMain.Size = new Size(708, 729);
            tblMain.TabIndex = 0;
            // 
            // lblCaptionRecipeName
            // 
            lblCaptionRecipeName.Anchor = AnchorStyles.Left;
            lblCaptionRecipeName.AutoSize = true;
            lblCaptionRecipeName.Location = new Point(4, 56);
            lblCaptionRecipeName.Margin = new Padding(4, 0, 4, 0);
            lblCaptionRecipeName.Name = "lblCaptionRecipeName";
            lblCaptionRecipeName.Size = new Size(126, 28);
            lblCaptionRecipeName.TabIndex = 0;
            lblCaptionRecipeName.Text = "Recipe Name";
            // 
            // txtRecipeName
            // 
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Location = new Point(275, 53);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(430, 34);
            txtRecipeName.TabIndex = 1;
            // 
            // lblCaptionUserFirstName
            // 
            lblCaptionUserFirstName.Anchor = AnchorStyles.Left;
            lblCaptionUserFirstName.AutoSize = true;
            lblCaptionUserFirstName.Location = new Point(4, 97);
            lblCaptionUserFirstName.Margin = new Padding(4, 0, 4, 0);
            lblCaptionUserFirstName.Name = "lblCaptionUserFirstName";
            lblCaptionUserFirstName.Size = new Size(108, 28);
            lblCaptionUserFirstName.TabIndex = 2;
            lblCaptionUserFirstName.Text = "User Name";
            // 
            // lstUserName
            // 
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(275, 93);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(231, 36);
            lstUserName.TabIndex = 3;
            // 
            // lblCaptionCuisineType
            // 
            lblCaptionCuisineType.Anchor = AnchorStyles.Left;
            lblCaptionCuisineType.AutoSize = true;
            lblCaptionCuisineType.Location = new Point(4, 139);
            lblCaptionCuisineType.Margin = new Padding(4, 0, 4, 0);
            lblCaptionCuisineType.Name = "lblCaptionCuisineType";
            lblCaptionCuisineType.Size = new Size(120, 28);
            lblCaptionCuisineType.TabIndex = 4;
            lblCaptionCuisineType.Text = "Cuisine Type";
            // 
            // lstCuisineType
            // 
            lstCuisineType.FormattingEnabled = true;
            lstCuisineType.Location = new Point(275, 135);
            lstCuisineType.Name = "lstCuisineType";
            lstCuisineType.Size = new Size(231, 36);
            lstCuisineType.TabIndex = 5;
            // 
            // lblCaptionCalorie
            // 
            lblCaptionCalorie.Anchor = AnchorStyles.Left;
            lblCaptionCalorie.AutoSize = true;
            lblCaptionCalorie.Location = new Point(4, 180);
            lblCaptionCalorie.Margin = new Padding(4, 0, 4, 0);
            lblCaptionCalorie.Name = "lblCaptionCalorie";
            lblCaptionCalorie.Size = new Size(73, 28);
            lblCaptionCalorie.TabIndex = 6;
            lblCaptionCalorie.Text = "Calorie";
            // 
            // txtCalorie
            // 
            txtCalorie.Dock = DockStyle.Fill;
            txtCalorie.Location = new Point(275, 177);
            txtCalorie.Name = "txtCalorie";
            txtCalorie.Size = new Size(430, 34);
            txtCalorie.TabIndex = 7;
            // 
            // lblCaptionRecipeStatus
            // 
            lblCaptionRecipeStatus.AutoSize = true;
            lblCaptionRecipeStatus.Location = new Point(4, 214);
            lblCaptionRecipeStatus.Margin = new Padding(4, 0, 4, 0);
            lblCaptionRecipeStatus.Name = "lblCaptionRecipeStatus";
            lblCaptionRecipeStatus.Size = new Size(135, 28);
            lblCaptionRecipeStatus.TabIndex = 8;
            lblCaptionRecipeStatus.Text = "Current Status";
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.AutoSize = true;
            lblRecipeStatus.Dock = DockStyle.Fill;
            lblRecipeStatus.Location = new Point(275, 214);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(430, 28);
            lblRecipeStatus.TabIndex = 9;
            // 
            // tblStatusDates
            // 
            tblStatusDates.ColumnCount = 3;
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblStatusDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblStatusDates.Controls.Add(lblCaptionDateDrafted, 0, 0);
            tblStatusDates.Controls.Add(lblCaptionDateArchived, 2, 0);
            tblStatusDates.Controls.Add(lblCaptionDatePublished, 1, 0);
            tblStatusDates.Controls.Add(lblDateDrafted, 0, 1);
            tblStatusDates.Controls.Add(lblDatePublished, 1, 1);
            tblStatusDates.Controls.Add(lblDateArchived, 2, 1);
            tblStatusDates.Dock = DockStyle.Fill;
            tblStatusDates.Location = new Point(275, 245);
            tblStatusDates.Name = "tblStatusDates";
            tblStatusDates.RowCount = 2;
            tblMain.SetRowSpan(tblStatusDates, 2);
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblStatusDates.RowStyles.Add(new RowStyle(SizeType.Absolute, 94F));
            tblStatusDates.Size = new Size(430, 125);
            tblStatusDates.TabIndex = 11;
            // 
            // lblCaptionDateDrafted
            // 
            lblCaptionDateDrafted.Anchor = AnchorStyles.Left;
            lblCaptionDateDrafted.AutoSize = true;
            lblCaptionDateDrafted.Location = new Point(4, 1);
            lblCaptionDateDrafted.Margin = new Padding(4, 0, 4, 0);
            lblCaptionDateDrafted.Name = "lblCaptionDateDrafted";
            lblCaptionDateDrafted.Size = new Size(78, 28);
            lblCaptionDateDrafted.TabIndex = 0;
            lblCaptionDateDrafted.Text = "Drafted";
            // 
            // lblCaptionDateArchived
            // 
            lblCaptionDateArchived.Anchor = AnchorStyles.Left;
            lblCaptionDateArchived.AutoSize = true;
            lblCaptionDateArchived.Location = new Point(290, 1);
            lblCaptionDateArchived.Margin = new Padding(4, 0, 4, 0);
            lblCaptionDateArchived.Name = "lblCaptionDateArchived";
            lblCaptionDateArchived.Size = new Size(89, 28);
            lblCaptionDateArchived.TabIndex = 2;
            lblCaptionDateArchived.Text = "Archived";
            // 
            // lblCaptionDatePublished
            // 
            lblCaptionDatePublished.Anchor = AnchorStyles.Left;
            lblCaptionDatePublished.AutoSize = true;
            lblCaptionDatePublished.Location = new Point(147, 1);
            lblCaptionDatePublished.Margin = new Padding(4, 0, 4, 0);
            lblCaptionDatePublished.Name = "lblCaptionDatePublished";
            lblCaptionDatePublished.Size = new Size(97, 28);
            lblCaptionDatePublished.TabIndex = 1;
            lblCaptionDatePublished.Text = "Published";
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.AutoSize = true;
            lblDateDrafted.Dock = DockStyle.Fill;
            lblDateDrafted.Location = new Point(3, 31);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(137, 94);
            lblDateDrafted.TabIndex = 3;
            // 
            // lblDatePublished
            // 
            lblDatePublished.AutoSize = true;
            lblDatePublished.Dock = DockStyle.Fill;
            lblDatePublished.Location = new Point(146, 31);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(137, 94);
            lblDatePublished.TabIndex = 4;
            // 
            // lblDateArchived
            // 
            lblDateArchived.AutoSize = true;
            lblDateArchived.Dock = DockStyle.Fill;
            lblDateArchived.Location = new Point(289, 31);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(138, 94);
            lblDateArchived.TabIndex = 5;
            // 
            // lblStatusDates
            // 
            lblStatusDates.AutoSize = true;
            lblStatusDates.Location = new Point(3, 250);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(119, 28);
            lblStatusDates.TabIndex = 10;
            lblStatusDates.Text = "Status Dates";
            // 
            // tbRecipe
            // 
            tblMain.SetColumnSpan(tbRecipe, 2);
            tbRecipe.Controls.Add(tabPage1);
            tbRecipe.Controls.Add(tabPage2);
            tbRecipe.Dock = DockStyle.Fill;
            tbRecipe.Location = new Point(3, 376);
            tbRecipe.Name = "tbRecipe";
            tbRecipe.SelectedIndex = 0;
            tbRecipe.Size = new Size(702, 350);
            tbRecipe.TabIndex = 12;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(4, 37);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(694, 309);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(gRecipeIngredient, 0, 1);
            tableLayoutPanel1.Controls.Add(btnSaveRecipeIngredient, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.5695362F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85.4304657F));
            tableLayoutPanel1.Size = new Size(688, 303);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // gRecipeIngredient
            // 
            gRecipeIngredient.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gRecipeIngredient.Dock = DockStyle.Fill;
            gRecipeIngredient.Location = new Point(3, 47);
            gRecipeIngredient.Name = "gRecipeIngredient";
            gRecipeIngredient.RowHeadersWidth = 51;
            gRecipeIngredient.Size = new Size(682, 253);
            gRecipeIngredient.TabIndex = 1;
            // 
            // btnSaveRecipeIngredient
            // 
            btnSaveRecipeIngredient.AutoSize = true;
            btnSaveRecipeIngredient.Location = new Point(3, 3);
            btnSaveRecipeIngredient.Name = "btnSaveRecipeIngredient";
            btnSaveRecipeIngredient.Size = new Size(94, 38);
            btnSaveRecipeIngredient.TabIndex = 2;
            btnSaveRecipeIngredient.Text = "Save";
            btnSaveRecipeIngredient.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tblRecipeDirection);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(694, 355);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tblRecipeDirection
            // 
            tblRecipeDirection.ColumnCount = 1;
            tblRecipeDirection.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblRecipeDirection.Controls.Add(gRecipeDirection, 0, 1);
            tblRecipeDirection.Controls.Add(btnSaveRecipeDirection, 0, 0);
            tblRecipeDirection.Dock = DockStyle.Fill;
            tblRecipeDirection.Location = new Point(3, 3);
            tblRecipeDirection.Name = "tblRecipeDirection";
            tblRecipeDirection.RowCount = 2;
            tblRecipeDirection.RowStyles.Add(new RowStyle(SizeType.Percent, 15.5629139F));
            tblRecipeDirection.RowStyles.Add(new RowStyle(SizeType.Percent, 84.43709F));
            tblRecipeDirection.Size = new Size(688, 349);
            tblRecipeDirection.TabIndex = 0;
            // 
            // gRecipeDirection
            // 
            gRecipeDirection.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gRecipeDirection.Dock = DockStyle.Fill;
            gRecipeDirection.Location = new Point(3, 57);
            gRecipeDirection.Name = "gRecipeDirection";
            gRecipeDirection.RowHeadersWidth = 51;
            gRecipeDirection.Size = new Size(682, 289);
            gRecipeDirection.TabIndex = 0;
            // 
            // btnSaveRecipeDirection
            // 
            btnSaveRecipeDirection.AutoSize = true;
            btnSaveRecipeDirection.Location = new Point(3, 3);
            btnSaveRecipeDirection.Name = "btnSaveRecipeDirection";
            btnSaveRecipeDirection.Size = new Size(94, 38);
            btnSaveRecipeDirection.TabIndex = 1;
            btnSaveRecipeDirection.Text = "Save";
            btnSaveRecipeDirection.UseVisualStyleBackColor = true;
            // 
            // tblButtons
            // 
            tblButtons.AutoSize = true;
            tblButtons.ColumnCount = 3;
            tblMain.SetColumnSpan(tblButtons, 2);
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.42529F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.57471F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 268F));
            tblButtons.Controls.Add(btnSave, 0, 0);
            tblButtons.Controls.Add(btnDelete, 1, 0);
            tblButtons.Controls.Add(btnChangeStatus, 2, 0);
            tblButtons.Dock = DockStyle.Fill;
            tblButtons.Location = new Point(3, 3);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblButtons.Size = new Size(702, 44);
            tblButtons.TabIndex = 13;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.Location = new Point(3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(91, 38);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = true;
            btnDelete.Location = new Point(217, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 38);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.AutoSize = true;
            btnChangeStatus.Location = new Point(436, 3);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(146, 38);
            btnChangeStatus.TabIndex = 2;
            btnChangeStatus.Text = "Change Status";
            btnChangeStatus.UseVisualStyleBackColor = true;
            // 
            // frmRecipeDetail
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 729);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmRecipeDetail";
            Text = "frmRecipeDetail";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblStatusDates.ResumeLayout(false);
            tblStatusDates.PerformLayout();
            tbRecipe.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipeIngredient).EndInit();
            tabPage2.ResumeLayout(false);
            tblRecipeDirection.ResumeLayout(false);
            tblRecipeDirection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipeDirection).EndInit();
            tblButtons.ResumeLayout(false);
            tblButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblCaptionRecipeName;
        private Label lblCaptionCuisineType;
        private Label lblCaptionCalorie;
        private Label lblCaptionUserFirstName;
        private Label lblCaptionDateDrafted;
        private Label lblCaptionDatePublished;
        private Label lblCaptionDateArchived;
        private Label lblCaptionRecipeStatus;
        private TextBox txtCalorie;
        private ComboBox lstCuisineType;
        private TextBox txtRecipeName;
        private ComboBox lstUserName;
        private Label lblRecipeStatus;
        private Label lblStatusDates;
        private TableLayoutPanel tblStatusDates;
        private TabControl tbRecipe;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView gRecipeIngredient;
        private TableLayoutPanel tblRecipeDirection;
        private DataGridView gRecipeDirection;
        private Button btnSaveRecipeDirection;
        private Button btnSaveRecipeIngredient;
        private TableLayoutPanel tblButtons;
        private Button btnSave;
        private Button btnDelete;
        private Button btnChangeStatus;
        private Label lblDatePublished;
        private Label lblDateArchived;
        private Label lblDateDrafted;
    }
}
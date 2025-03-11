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
            lblCaptionCuisineType = new Label();
            lblCaptionCalorie = new Label();
            lblCaptionUserFirstName = new Label();
            lblCaptionUserLastName = new Label();
            lblCaptionDateDrafted = new Label();
            lblCaptionDatePublished = new Label();
            lblCaptionDateArchived = new Label();
            lblCaptionRecipeStatus = new Label();
            lblRecipeName = new Label();
            lblCuisineType = new Label();
            lblCalorie = new Label();
            lblUserFirstName = new Label();
            lblUserLastName = new Label();
            lblDateDrafted = new Label();
            lblDatePublished = new Label();
            lblDateArchived = new Label();
            lblRecipeStatus = new Label();
            tblMain.SuspendLayout();
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
            tblMain.Controls.Add(lblRecipeName, 1, 0);
            tblMain.Controls.Add(lblCuisineType, 1, 1);
            tblMain.Controls.Add(lblCalorie, 1, 2);
            tblMain.Controls.Add(lblUserFirstName, 1, 3);
            tblMain.Controls.Add(lblUserLastName, 1, 4);
            tblMain.Controls.Add(lblDateDrafted, 1, 5);
            tblMain.Controls.Add(lblDatePublished, 1, 6);
            tblMain.Controls.Add(lblDateArchived, 1, 7);
            tblMain.Controls.Add(lblRecipeStatus, 1, 8);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4, 4, 4, 4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 9;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.Size = new Size(645, 630);
            tblMain.TabIndex = 0;
            // 
            // lblCaptionRecipeName
            // 
            lblCaptionRecipeName.Anchor = AnchorStyles.Left;
            lblCaptionRecipeName.AutoSize = true;
            lblCaptionRecipeName.Location = new Point(4, 0);
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
            lblCaptionCuisineType.Location = new Point(4, 28);
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
            lblCaptionCalorie.Location = new Point(4, 56);
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
            lblCaptionUserFirstName.Location = new Point(4, 84);
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
            lblCaptionUserLastName.Location = new Point(4, 112);
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
            lblCaptionDateDrafted.Location = new Point(4, 140);
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
            lblCaptionDatePublished.Location = new Point(4, 168);
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
            lblCaptionDateArchived.Location = new Point(4, 196);
            lblCaptionDateArchived.Margin = new Padding(4, 0, 4, 0);
            lblCaptionDateArchived.Name = "lblCaptionDateArchived";
            lblCaptionDateArchived.Size = new Size(135, 28);
            lblCaptionDateArchived.TabIndex = 7;
            lblCaptionDateArchived.Text = "Date Archived";
            // 
            // lblCaptionRecipeStatus
            // 
            lblCaptionRecipeStatus.AutoSize = true;
            lblCaptionRecipeStatus.Location = new Point(4, 224);
            lblCaptionRecipeStatus.Margin = new Padding(4, 0, 4, 0);
            lblCaptionRecipeStatus.Name = "lblCaptionRecipeStatus";
            lblCaptionRecipeStatus.Size = new Size(127, 28);
            lblCaptionRecipeStatus.TabIndex = 8;
            lblCaptionRecipeStatus.Text = "Recipe Status";
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.BackColor = Color.WhiteSmoke;
            lblRecipeName.Dock = DockStyle.Fill;
            lblRecipeName.Location = new Point(251, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(391, 28);
            lblRecipeName.TabIndex = 9;
            // 
            // lblCuisineType
            // 
            lblCuisineType.AutoSize = true;
            lblCuisineType.BackColor = Color.WhiteSmoke;
            lblCuisineType.Dock = DockStyle.Fill;
            lblCuisineType.Location = new Point(251, 28);
            lblCuisineType.Name = "lblCuisineType";
            lblCuisineType.Size = new Size(391, 28);
            lblCuisineType.TabIndex = 10;
            // 
            // lblCalorie
            // 
            lblCalorie.AutoSize = true;
            lblCalorie.BackColor = Color.WhiteSmoke;
            lblCalorie.Dock = DockStyle.Fill;
            lblCalorie.Location = new Point(251, 56);
            lblCalorie.Name = "lblCalorie";
            lblCalorie.Size = new Size(391, 28);
            lblCalorie.TabIndex = 11;
            // 
            // lblUserFirstName
            // 
            lblUserFirstName.AutoSize = true;
            lblUserFirstName.BackColor = Color.WhiteSmoke;
            lblUserFirstName.Dock = DockStyle.Fill;
            lblUserFirstName.Location = new Point(251, 84);
            lblUserFirstName.Name = "lblUserFirstName";
            lblUserFirstName.Size = new Size(391, 28);
            lblUserFirstName.TabIndex = 12;
            // 
            // lblUserLastName
            // 
            lblUserLastName.AutoSize = true;
            lblUserLastName.BackColor = Color.WhiteSmoke;
            lblUserLastName.Dock = DockStyle.Fill;
            lblUserLastName.Location = new Point(251, 112);
            lblUserLastName.Name = "lblUserLastName";
            lblUserLastName.Size = new Size(391, 28);
            lblUserLastName.TabIndex = 13;
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.AutoSize = true;
            lblDateDrafted.BackColor = Color.WhiteSmoke;
            lblDateDrafted.Dock = DockStyle.Fill;
            lblDateDrafted.Location = new Point(251, 140);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(391, 28);
            lblDateDrafted.TabIndex = 14;
            // 
            // lblDatePublished
            // 
            lblDatePublished.AutoSize = true;
            lblDatePublished.BackColor = Color.WhiteSmoke;
            lblDatePublished.Dock = DockStyle.Fill;
            lblDatePublished.Location = new Point(251, 168);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(391, 28);
            lblDatePublished.TabIndex = 15;
            // 
            // lblDateArchived
            // 
            lblDateArchived.AutoSize = true;
            lblDateArchived.BackColor = Color.WhiteSmoke;
            lblDateArchived.Dock = DockStyle.Fill;
            lblDateArchived.Location = new Point(251, 196);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(391, 28);
            lblDateArchived.TabIndex = 16;
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.AutoSize = true;
            lblRecipeStatus.BackColor = Color.WhiteSmoke;
            lblRecipeStatus.Dock = DockStyle.Fill;
            lblRecipeStatus.Location = new Point(251, 224);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(391, 406);
            lblRecipeStatus.TabIndex = 17;
            // 
            // frmRecipeDetail
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 630);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmRecipeDetail";
            Text = "frmRecipeDetail";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ResumeLayout(false);
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
        private Label lblRecipeName;
        private Label lblCuisineType;
        private Label lblCalorie;
        private Label lblUserFirstName;
        private Label lblUserLastName;
        private Label lblDateDrafted;
        private Label lblDatePublished;
        private Label lblDateArchived;
        private Label lblRecipeStatus;
    }
}
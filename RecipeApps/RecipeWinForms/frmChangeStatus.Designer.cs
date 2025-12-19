namespace RecipeWinForms
{
    partial class frmChangeStatus
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
            lblRecipeName = new Label();
            tblStatusButtons = new TableLayoutPanel();
            lblStatusDates = new Label();
            lblDrafted = new Label();
            lblPublished = new Label();
            lblArchived = new Label();
            lblDateDrafted = new Label();
            lblDateArchived = new Label();
            lblDatePublished = new Label();
            tblChangeStatusButtons = new TableLayoutPanel();
            btnDraft = new Button();
            btnPublish = new Button();
            btnArchive = new Button();
            tblCurrentStatus = new TableLayoutPanel();
            lblCurrentStatus = new Label();
            lblRecipeStatus = new Label();
            tblMain.SuspendLayout();
            tblStatusButtons.SuspendLayout();
            tblChangeStatusButtons.SuspendLayout();
            tblCurrentStatus.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblRecipeName, 0, 0);
            tblMain.Controls.Add(tblStatusButtons, 0, 2);
            tblMain.Controls.Add(tblCurrentStatus, 0, 1);
            tblMain.Controls.Add(tblChangeStatusButtons, 0, 4);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 5;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblMain.Size = new Size(798, 323);
            tblMain.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.Dock = DockStyle.Fill;
            lblRecipeName.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecipeName.Location = new Point(3, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(792, 64);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblStatusButtons
            // 
            tblStatusButtons.ColumnCount = 5;
            tblStatusButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblStatusButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblStatusButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblStatusButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblStatusButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tblStatusButtons.Controls.Add(lblStatusDates, 0, 1);
            tblStatusButtons.Controls.Add(lblDrafted, 1, 0);
            tblStatusButtons.Controls.Add(lblPublished, 2, 0);
            tblStatusButtons.Controls.Add(lblArchived, 3, 0);
            tblStatusButtons.Controls.Add(lblDateDrafted, 1, 1);
            tblStatusButtons.Controls.Add(lblDateArchived, 3, 1);
            tblStatusButtons.Controls.Add(lblDatePublished, 2, 1);
            tblStatusButtons.Dock = DockStyle.Fill;
            tblStatusButtons.Location = new Point(3, 131);
            tblStatusButtons.Name = "tblStatusButtons";
            tblStatusButtons.RowCount = 2;
            tblMain.SetRowSpan(tblStatusButtons, 2);
            tblStatusButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblStatusButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblStatusButtons.Size = new Size(792, 122);
            tblStatusButtons.TabIndex = 2;
            // 
            // lblStatusDates
            // 
            lblStatusDates.AutoSize = true;
            lblStatusDates.Dock = DockStyle.Fill;
            lblStatusDates.Location = new Point(3, 61);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(152, 61);
            lblStatusDates.TabIndex = 0;
            lblStatusDates.Text = "Status Dates";
            // 
            // lblDrafted
            // 
            lblDrafted.AutoSize = true;
            lblDrafted.Dock = DockStyle.Fill;
            lblDrafted.Location = new Point(161, 0);
            lblDrafted.Name = "lblDrafted";
            lblDrafted.Size = new Size(152, 61);
            lblDrafted.TabIndex = 1;
            lblDrafted.Text = "Drafted";
            lblDrafted.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblPublished
            // 
            lblPublished.AutoSize = true;
            lblPublished.Dock = DockStyle.Fill;
            lblPublished.Location = new Point(319, 0);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(152, 61);
            lblPublished.TabIndex = 2;
            lblPublished.Text = "Published";
            lblPublished.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblArchived
            // 
            lblArchived.AutoSize = true;
            lblArchived.Dock = DockStyle.Fill;
            lblArchived.Location = new Point(477, 0);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(152, 61);
            lblArchived.TabIndex = 3;
            lblArchived.Text = "Archived";
            lblArchived.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblDateDrafted
            // 
            lblDateDrafted.AutoSize = true;
            lblDateDrafted.Dock = DockStyle.Fill;
            lblDateDrafted.Location = new Point(161, 61);
            lblDateDrafted.Name = "lblDateDrafted";
            lblDateDrafted.Size = new Size(152, 61);
            lblDateDrafted.TabIndex = 4;
            lblDateDrafted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDateArchived
            // 
            lblDateArchived.AutoSize = true;
            lblDateArchived.Dock = DockStyle.Fill;
            lblDateArchived.Location = new Point(477, 61);
            lblDateArchived.Name = "lblDateArchived";
            lblDateArchived.Size = new Size(152, 61);
            lblDateArchived.TabIndex = 6;
            lblDateArchived.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDatePublished
            // 
            lblDatePublished.AutoSize = true;
            lblDatePublished.Dock = DockStyle.Fill;
            lblDatePublished.Location = new Point(319, 61);
            lblDatePublished.Name = "lblDatePublished";
            lblDatePublished.Size = new Size(152, 61);
            lblDatePublished.TabIndex = 7;
            lblDatePublished.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblChangeStatusButtons
            // 
            tblChangeStatusButtons.Anchor = AnchorStyles.Top;
            tblChangeStatusButtons.AutoSize = true;
            tblChangeStatusButtons.ColumnCount = 3;
            tblChangeStatusButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblChangeStatusButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblChangeStatusButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblChangeStatusButtons.Controls.Add(btnDraft, 0, 0);
            tblChangeStatusButtons.Controls.Add(btnPublish, 1, 0);
            tblChangeStatusButtons.Controls.Add(btnArchive, 2, 0);
            tblChangeStatusButtons.Location = new Point(153, 259);
            tblChangeStatusButtons.Name = "tblChangeStatusButtons";
            tblChangeStatusButtons.RowCount = 1;
            tblChangeStatusButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblChangeStatusButtons.Size = new Size(492, 61);
            tblChangeStatusButtons.TabIndex = 3;
            // 
            // btnDraft
            // 
            btnDraft.AutoSize = true;
            btnDraft.Dock = DockStyle.Fill;
            btnDraft.Location = new Point(3, 3);
            btnDraft.Name = "btnDraft";
            btnDraft.Size = new Size(158, 55);
            btnDraft.TabIndex = 0;
            btnDraft.Text = "Draft";
            btnDraft.UseVisualStyleBackColor = true;
            // 
            // btnPublish
            // 
            btnPublish.AutoSize = true;
            btnPublish.Dock = DockStyle.Fill;
            btnPublish.Location = new Point(167, 3);
            btnPublish.Name = "btnPublish";
            btnPublish.Size = new Size(158, 55);
            btnPublish.TabIndex = 1;
            btnPublish.Text = "Publish";
            btnPublish.UseVisualStyleBackColor = true;
            // 
            // btnArchive
            // 
            btnArchive.AutoSize = true;
            btnArchive.Dock = DockStyle.Fill;
            btnArchive.Location = new Point(331, 3);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(158, 55);
            btnArchive.TabIndex = 2;
            btnArchive.Text = "Archive";
            btnArchive.UseVisualStyleBackColor = true;
            // 
            // tblCurrentStatus
            // 
            tblCurrentStatus.ColumnCount = 2;
            tblCurrentStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblCurrentStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblCurrentStatus.Controls.Add(lblCurrentStatus, 0, 0);
            tblCurrentStatus.Controls.Add(lblRecipeStatus, 1, 0);
            tblCurrentStatus.Dock = DockStyle.Fill;
            tblCurrentStatus.Location = new Point(3, 67);
            tblCurrentStatus.Name = "tblCurrentStatus";
            tblCurrentStatus.RowCount = 1;
            tblCurrentStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblCurrentStatus.Size = new Size(792, 58);
            tblCurrentStatus.TabIndex = 4;
            // 
            // lblCurrentStatus
            // 
            lblCurrentStatus.AutoSize = true;
            lblCurrentStatus.Dock = DockStyle.Fill;
            lblCurrentStatus.Location = new Point(3, 0);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(390, 58);
            lblCurrentStatus.TabIndex = 0;
            lblCurrentStatus.Text = "Current Status:";
            lblCurrentStatus.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.AutoSize = true;
            lblRecipeStatus.Dock = DockStyle.Fill;
            lblRecipeStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecipeStatus.Location = new Point(399, 0);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(390, 58);
            lblRecipeStatus.TabIndex = 1;
            lblRecipeStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmChangeStatus
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 323);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmChangeStatus";
            Text = "Change Status";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblStatusButtons.ResumeLayout(false);
            tblStatusButtons.PerformLayout();
            tblChangeStatusButtons.ResumeLayout(false);
            tblChangeStatusButtons.PerformLayout();
            tblCurrentStatus.ResumeLayout(false);
            tblCurrentStatus.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblRecipeName;
        private TableLayoutPanel tblStatusButtons;
        private Label lblStatusDates;
        private Label lblDrafted;
        private Label lblPublished;
        private Label lblArchived;
        private TableLayoutPanel tblChangeStatusButtons;
        private Button btnDraft;
        private Button btnPublish;
        private Button btnArchive;
        private TableLayoutPanel tblCurrentStatus;
        private Label lblCurrentStatus;
        private Label lblRecipeStatus;
        private Label lblDateDrafted;
        private Label lblDateArchived;
        private Label lblDatePublished;
    }
}
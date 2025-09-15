namespace RecipeWinForms
{
    partial class frmDashboard
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
            gMain = new DataGridView();
            lblWelcomeMessage = new Label();
            lblWelcomeDetails = new Label();
            tblButtons = new TableLayoutPanel();
            btnRecipeList = new Button();
            btnMealList = new Button();
            btnCookbookList = new Button();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gMain).BeginInit();
            tblButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.AutoSize = true;
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.Controls.Add(gMain, 0, 2);
            tblMain.Controls.Add(lblWelcomeMessage, 0, 0);
            tblMain.Controls.Add(lblWelcomeDetails, 0, 1);
            tblMain.Controls.Add(tblButtons, 0, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15.7142859F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 28.25397F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 30.7936516F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblMain.Size = new Size(1100, 630);
            tblMain.TabIndex = 0;
            // 
            // gMain
            // 
            gMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            gMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gMain.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gMain.Location = new Point(400, 280);
            gMain.Name = "gMain";
            gMain.RowHeadersWidth = 51;
            gMain.Size = new Size(300, 188);
            gMain.TabIndex = 1;
            // 
            // lblWelcomeMessage
            // 
            lblWelcomeMessage.Anchor = AnchorStyles.Bottom;
            lblWelcomeMessage.AutoSize = true;
            lblWelcomeMessage.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcomeMessage.Location = new Point(359, 58);
            lblWelcomeMessage.Name = "lblWelcomeMessage";
            lblWelcomeMessage.Size = new Size(381, 41);
            lblWelcomeMessage.TabIndex = 2;
            lblWelcomeMessage.Text = "Hearty Health Desktop App";
            // 
            // lblWelcomeDetails
            // 
            lblWelcomeDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblWelcomeDetails.AutoSize = true;
            lblWelcomeDetails.Location = new Point(133, 124);
            lblWelcomeDetails.Margin = new Padding(3, 25, 3, 0);
            lblWelcomeDetails.Name = "lblWelcomeDetails";
            lblWelcomeDetails.Size = new Size(833, 153);
            lblWelcomeDetails.TabIndex = 3;
            lblWelcomeDetails.Text = "Welcome to the Hearty Hearth desktop app. In this app you can create recipes and cookbooks.";
            // 
            // tblButtons
            // 
            tblButtons.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tblButtons.AutoSize = true;
            tblButtons.ColumnCount = 3;
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tblButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tblButtons.Controls.Add(btnRecipeList, 0, 0);
            tblButtons.Controls.Add(btnMealList, 1, 0);
            tblButtons.Controls.Add(btnCookbookList, 2, 0);
            tblButtons.Location = new Point(3, 474);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblButtons.Size = new Size(1094, 153);
            tblButtons.TabIndex = 0;
            // 
            // btnRecipeList
            // 
            btnRecipeList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnRecipeList.Location = new Point(248, 3);
            btnRecipeList.Name = "btnRecipeList";
            btnRecipeList.Size = new Size(113, 147);
            btnRecipeList.TabIndex = 0;
            btnRecipeList.Text = "Recipe List";
            btnRecipeList.UseVisualStyleBackColor = true;
            // 
            // btnMealList
            // 
            btnMealList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnMealList.Location = new Point(496, 3);
            btnMealList.Name = "btnMealList";
            btnMealList.Size = new Size(99, 147);
            btnMealList.TabIndex = 1;
            btnMealList.Text = "Meal List";
            btnMealList.UseVisualStyleBackColor = true;
            // 
            // btnCookbookList
            // 
            btnCookbookList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnCookbookList.Location = new Point(731, 3);
            btnCookbookList.Name = "btnCookbookList";
            btnCookbookList.Size = new Size(148, 147);
            btnCookbookList.TabIndex = 2;
            btnCookbookList.Text = "Cookbook List";
            btnCookbookList.UseVisualStyleBackColor = true;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 630);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmDashboard";
            Text = "Dashboard";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gMain).EndInit();
            tblButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TableLayoutPanel tblButtons;
        private Button btnRecipeList;
        private Button btnMealList;
        private Button btnCookbookList;
        private DataGridView gMain;
        private Label lblWelcomeMessage;
        private Label lblWelcomeDetails;
    }
}
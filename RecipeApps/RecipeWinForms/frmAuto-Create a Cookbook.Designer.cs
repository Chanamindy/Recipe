namespace RecipeWinForms
{
    partial class frmAutoCreateCookbook
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
            btnCreateCookbook = new Button();
            lstUserStaff = new ComboBox();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(btnCreateCookbook, 1, 0);
            tblMain.Controls.Add(lstUserStaff, 0, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 1;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.Size = new Size(784, 247);
            tblMain.TabIndex = 0;
            // 
            // btnCreateCookbook
            // 
            btnCreateCookbook.Anchor = AnchorStyles.Left;
            btnCreateCookbook.AutoSize = true;
            btnCreateCookbook.Location = new Point(396, 103);
            btnCreateCookbook.Margin = new Padding(4);
            btnCreateCookbook.Name = "btnCreateCookbook";
            btnCreateCookbook.Size = new Size(190, 41);
            btnCreateCookbook.TabIndex = 1;
            btnCreateCookbook.Text = "Create a Cookbook";
            btnCreateCookbook.UseVisualStyleBackColor = true;
            // 
            // lstUserStaff
            // 
            lstUserStaff.Anchor = AnchorStyles.Right;
            lstUserStaff.FormattingEnabled = true;
            lstUserStaff.Location = new Point(182, 109);
            lstUserStaff.Margin = new Padding(4);
            lstUserStaff.Name = "lstUserStaff";
            lstUserStaff.Size = new Size(206, 36);
            lstUserStaff.TabIndex = 0;
            // 
            // frmAutoCreateCookbook
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 247);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmAutoCreateCookbook";
            Text = "Auto Create a Cookbook";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private ComboBox lstUserStaff;
        private Button btnCreateCookbook;
    }
}
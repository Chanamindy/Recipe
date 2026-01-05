namespace RecipeWinForms
{
    partial class frmLogin
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
            lblUserName = new Label();
            lblPassword = new Label();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            tblButtons = new TableLayoutPanel();
            btnOk = new Button();
            btnCancel = new Button();
            tblMain.SuspendLayout();
            tblButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(lblUserName, 0, 0);
            tblMain.Controls.Add(lblPassword, 0, 1);
            tblMain.Controls.Add(txtUserName, 1, 0);
            tblMain.Controls.Add(txtPassword, 1, 1);
            tblMain.Controls.Add(tblButtons, 1, 2);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(649, 149);
            tblMain.TabIndex = 0;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Dock = DockStyle.Fill;
            lblUserName.Location = new Point(4, 0);
            lblUserName.Margin = new Padding(4, 0, 4, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(108, 42);
            lblUserName.TabIndex = 0;
            lblUserName.Text = "User Name";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Dock = DockStyle.Fill;
            lblPassword.Location = new Point(4, 42);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(108, 42);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // txtUserName
            // 
            txtUserName.Dock = DockStyle.Fill;
            txtUserName.Location = new Point(120, 4);
            txtUserName.Margin = new Padding(4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(525, 34);
            txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Location = new Point(120, 46);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(525, 34);
            txtPassword.TabIndex = 3;
            // 
            // tblButtons
            // 
            tblButtons.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            tblButtons.AutoSize = true;
            tblButtons.ColumnCount = 2;
            tblButtons.ColumnStyles.Add(new ColumnStyle());
            tblButtons.ColumnStyles.Add(new ColumnStyle());
            tblButtons.Controls.Add(btnOk, 0, 0);
            tblButtons.Controls.Add(btnCancel, 1, 0);
            tblButtons.Location = new Point(446, 87);
            tblButtons.Name = "tblButtons";
            tblButtons.RowCount = 1;
            tblButtons.RowStyles.Add(new RowStyle());
            tblButtons.Size = new Size(200, 44);
            tblButtons.TabIndex = 4;
            // 
            // btnOk
            // 
            btnOk.AutoSize = true;
            btnOk.Location = new Point(3, 3);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(94, 38);
            btnOk.TabIndex = 0;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.Location = new Point(103, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 38);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmLogin
            // 
            AcceptButton = btnOk;
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(649, 149);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLogin";
            Text = "Login";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblButtons.ResumeLayout(false);
            tblButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblUserName;
        private Label lblPassword;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private TableLayoutPanel tblButtons;
        private Button btnOk;
        private Button btnCancel;
    }
}
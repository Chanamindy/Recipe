namespace RecipeWinForms
{
    partial class frmCloneRecipe
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lstRecipe = new ComboBox();
            btnClone = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.61039F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.38961F));
            tableLayoutPanel1.Controls.Add(lstRecipe, 0, 0);
            tableLayoutPanel1.Controls.Add(btnClone, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 41.7159767F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 58.2840233F));
            tableLayoutPanel1.Size = new Size(770, 338);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lstRecipe
            // 
            lstRecipe.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lstRecipe.FormattingEnabled = true;
            lstRecipe.Location = new Point(305, 88);
            lstRecipe.Margin = new Padding(3, 3, 3, 25);
            lstRecipe.Name = "lstRecipe";
            lstRecipe.Size = new Size(151, 36);
            lstRecipe.TabIndex = 0;
            // 
            // btnClone
            // 
            btnClone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClone.AutoSize = true;
            btnClone.Location = new Point(362, 144);
            btnClone.Name = "btnClone";
            btnClone.Size = new Size(94, 38);
            btnClone.TabIndex = 1;
            btnClone.Text = "Clone";
            btnClone.UseVisualStyleBackColor = true;
            // 
            // frmCloneRecipe
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 338);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmCloneRecipe";
            Text = "Clone a Recipe";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox lstRecipe;
        private Button btnClone;
    }
}
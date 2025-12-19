namespace RecipeWinForms
{
    partial class frmDataMaintenance
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
            btnSave = new Button();
            pnlRadioButtons = new FlowLayoutPanel();
            optUsers = new RadioButton();
            optCuisines = new RadioButton();
            optIngredients = new RadioButton();
            optMeasurements = new RadioButton();
            optCourses = new RadioButton();
            gDataMaintenance = new DataGridView();
            tblMain.SuspendLayout();
            pnlRadioButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gDataMaintenance).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.AutoSize = true;
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(btnSave, 0, 0);
            tblMain.Controls.Add(pnlRadioButtons, 0, 1);
            tblMain.Controls.Add(gDataMaintenance, 1, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.8571424F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 87.14286F));
            tblMain.Size = new Size(1100, 630);
            tblMain.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.Dock = DockStyle.Fill;
            btnSave.Location = new Point(3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(214, 74);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // pnlRadioButtons
            // 
            pnlRadioButtons.AutoSize = true;
            pnlRadioButtons.Controls.Add(optUsers);
            pnlRadioButtons.Controls.Add(optCuisines);
            pnlRadioButtons.Controls.Add(optIngredients);
            pnlRadioButtons.Controls.Add(optMeasurements);
            pnlRadioButtons.Controls.Add(optCourses);
            pnlRadioButtons.Dock = DockStyle.Fill;
            pnlRadioButtons.Location = new Point(3, 83);
            pnlRadioButtons.Name = "pnlRadioButtons";
            pnlRadioButtons.Size = new Size(214, 544);
            pnlRadioButtons.TabIndex = 1;
            // 
            // optUsers
            // 
            optUsers.AutoSize = true;
            optUsers.Checked = true;
            optUsers.Location = new Point(10, 10);
            optUsers.Margin = new Padding(10);
            optUsers.Name = "optUsers";
            optUsers.Size = new Size(80, 32);
            optUsers.TabIndex = 0;
            optUsers.TabStop = true;
            optUsers.Text = "Users";
            optUsers.UseVisualStyleBackColor = true;
            // 
            // optCuisines
            // 
            optCuisines.AutoSize = true;
            optCuisines.Location = new Point(10, 62);
            optCuisines.Margin = new Padding(10);
            optCuisines.Name = "optCuisines";
            optCuisines.Size = new Size(103, 32);
            optCuisines.TabIndex = 1;
            optCuisines.Text = "Cuisines";
            optCuisines.UseVisualStyleBackColor = true;
            // 
            // optIngredients
            // 
            optIngredients.AutoSize = true;
            optIngredients.Location = new Point(10, 114);
            optIngredients.Margin = new Padding(10);
            optIngredients.Name = "optIngredients";
            optIngredients.Size = new Size(131, 32);
            optIngredients.TabIndex = 2;
            optIngredients.Text = "Ingredients";
            optIngredients.UseVisualStyleBackColor = true;
            // 
            // optMeasurements
            // 
            optMeasurements.AutoSize = true;
            optMeasurements.Location = new Point(10, 166);
            optMeasurements.Margin = new Padding(10);
            optMeasurements.Name = "optMeasurements";
            optMeasurements.Size = new Size(160, 32);
            optMeasurements.TabIndex = 3;
            optMeasurements.Text = "Measurements";
            optMeasurements.UseVisualStyleBackColor = true;
            // 
            // optCourses
            // 
            optCourses.AutoSize = true;
            optCourses.Location = new Point(10, 218);
            optCourses.Margin = new Padding(10);
            optCourses.Name = "optCourses";
            optCourses.Size = new Size(101, 32);
            optCourses.TabIndex = 4;
            optCourses.Text = "Courses";
            optCourses.UseVisualStyleBackColor = true;
            // 
            // gDataMaintenance
            // 
            gDataMaintenance.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            gDataMaintenance.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            gDataMaintenance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gDataMaintenance.Dock = DockStyle.Fill;
            gDataMaintenance.Location = new Point(223, 83);
            gDataMaintenance.Name = "gDataMaintenance";
            gDataMaintenance.RowHeadersWidth = 51;
            gDataMaintenance.Size = new Size(874, 544);
            gDataMaintenance.TabIndex = 1;
            // 
            // frmDataMaintenance
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 630);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmDataMaintenance";
            Text = "Data Maintenance";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            pnlRadioButtons.ResumeLayout(false);
            pnlRadioButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gDataMaintenance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnSave;
        private FlowLayoutPanel pnlRadioButtons;
        private RadioButton optUsers;
        private RadioButton optCuisines;
        private RadioButton optIngredients;
        private RadioButton optMeasurements;
        private RadioButton optCourses;
        private DataGridView gDataMaintenance;
    }
}
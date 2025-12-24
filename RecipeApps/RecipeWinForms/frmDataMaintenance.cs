using System.Data.Common;

namespace RecipeWinForms
{
    public partial class frmDataMaintenance : Form
    {
        private enum TableTypeEnum { UserStaff, Cuisine, Ingredient, Measurement, Course };
        TableTypeEnum currenttabletype = TableTypeEnum.UserStaff;
        string deletecolname = "deletecol";
        DataTable dt;

        public frmDataMaintenance()
        {
            InitializeComponent();
            optUsers.Tag = TableTypeEnum.UserStaff;
            SetUpRadioButtons();
            BindData(currenttabletype);
            optUsers.Click += Opt_Click;
            optCuisines.Click += Opt_Click;
            optIngredients.Click += Opt_Click;
            optMeasurements.Click += Opt_Click;
            optCourses.Click += Opt_Click;
            gDataMaintenance.CellContentClick += GDataMaintenance_CellContentClick;
            gDataMaintenance.DataError += GDataMaintenance_DataError;
            btnSave.Click += BtnSave_Click;
        }

        private void BindData(TableTypeEnum tabletype)
        {
            currenttabletype = tabletype;
            gDataMaintenance.Columns.Clear();
            string procname = tabletype.ToString();
            dt = DataMaintenance.DataListGet(procname);
            gDataMaintenance.DataSource = dt;
            WindowsFormsUtility.FormatGridForEdit(gDataMaintenance, tabletype.ToString());
            WindowsFormsUtility.AddDeleteButtonToGrid(gDataMaintenance, deletecolname);
            gDataMaintenance.Show();
        }

        private void Delete(int rowindex)
        {
            int id = 0;
            id = WindowsFormsUtility.GetIdFromGrid(gDataMaintenance, rowindex, currenttabletype.ToString() + "Id");
            if (id != 0)
            {
                string message = "Do you want to Delete this " + currenttabletype.ToString() + "?";
                if (currenttabletype == TableTypeEnum.UserStaff)
                {
                    message = "Are you sure you want to delete this user and all related recipes, meals, and cookbooks?";
                }
                var response = MessageBox.Show(message, currenttabletype.ToString(), MessageBoxButtons.YesNo);
                if (response == DialogResult.No)
                {
                    return;
                }
                Application.UseWaitCursor = true;
                try
                {
                    DataMaintenance.DeleteRow(currenttabletype.ToString(), id);
                    BindData(currenttabletype);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Application.UseWaitCursor = false;
                }
            }
            else if (id == 0 && rowindex < gDataMaintenance.Rows.Count)
            {
                gDataMaintenance.Rows.Remove(gDataMaintenance.Rows[rowindex]);
            }
        }

        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                foreach (DataRow r in dt.Select("", "", DataViewRowState.Added))
                {
                    SQLUtility.SaveDataRow(r, currenttabletype.ToString() + "Update");
                }
                if (currenttabletype == TableTypeEnum.UserStaff)
                {
                    BindData(currenttabletype);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }

        private void SetUpRadioButtons()
        {
            foreach (Control c in pnlRadioButtons.Controls)
            {
                if (c is RadioButton)
                {
                    c.Click += C_Click;
                }
                optUsers.Tag = TableTypeEnum.UserStaff;
                optCuisines.Tag = TableTypeEnum.Cuisine;
                optIngredients.Tag = TableTypeEnum.Ingredient;
                optMeasurements.Tag = TableTypeEnum.Measurement;
                optCourses.Tag = TableTypeEnum.Course;
            }
        }

        private void C_Click(object? sender, EventArgs e)
        {
            if (sender is Control && ((Control)sender).Tag is TableTypeEnum)
            {
                BindData((TableTypeEnum)((Control)sender).Tag);
            }
        }

        private void Opt_Click(object? sender, EventArgs e)
        {
            SetUpRadioButtons();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void GDataMaintenance_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (gDataMaintenance.Columns[e.ColumnIndex].Name == deletecolname)
            {
                Delete(e.RowIndex);
            }
        }

        private void GDataMaintenance_DataError(object? sender, DataGridViewDataErrorEventArgs e)
        {
            string columnname = gDataMaintenance.Columns[e.ColumnIndex].Name;
            bool b = SQLUtility.CheckValueIfInt(sender.ToString());
            if (sender.ToString() != "" && b == false)
            {
                MessageBox.Show(columnname + " must be an interger.");
            }
        }
    }
}

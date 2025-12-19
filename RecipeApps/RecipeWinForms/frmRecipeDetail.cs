using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RecipeWinForms
{
    public partial class frmRecipeDetail : Form
    {
        DataTable dtRecipe;
        DataTable dtRecipeIngredient;
        DataTable dtIngredient;
        DataTable dtMeasurement;
        DataTable dtRecipeDirection;
        BindingSource bindsource = new BindingSource();
        int recipeid = 0;
        string deletecolname = "deletcol";

        public frmRecipeDetail()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnChangeStatus.Click += BtnChangeStatus_Click;
            btnSaveRecipeIngredient.Click += BtnSaveRecipeIngredient_Click;
            btnSaveRecipeDirection.Click += BtnSaveRecipeDirection_Click;
            gRecipeIngredient.CellContentClick += GRecipeIngredient_CellContentClick;
            gRecipeDirection.CellContentClick += GRecipeDirection_CellContentClick;
            txtCalorie.TextChanged += TxtCalorie_TextChanged;
            gRecipeIngredient.TabIndexChanged += GRecipeIngredient_TabIndexChanged;///
            this.Shown += FrmRecipeDetail_Shown;
        }

        private void GRecipeIngredient_TabIndexChanged(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FrmRecipeDetail_Shown(object? sender, EventArgs e)
        {
            LoadRecipeIngredientTable(recipeid);
            LoadRecipeDirectionTable(recipeid);
        }

        public void LoadForm(int RecipeId)
        {
            recipeid = RecipeId;
            this.Tag = recipeid;
            dtRecipe = Recipe.Load(recipeid);
            bindsource.DataSource = dtRecipe;
            if (recipeid == 0)
            {
                dtRecipe.Rows.Add();
            }
            DataTable dtCuisine = Recipe.GetCuisineList();
            SQLUtility.DebugPrintDataTable(dtCuisine);
            DataTable dtUserStaff = Recipe.GetUserStaffList();
            SQLUtility.DebugPrintDataTable(dtUserStaff);
            WindowsFormsUtility.SetListBinding(lstCuisineType, dtCuisine, dtRecipe, "Cuisine");
            WindowsFormsUtility.SetListBinding(lstUserName, dtUserStaff, dtRecipe, "UserStaff");
            WindowsFormsUtility.SetControlBinding(txtRecipeName, bindsource);
            WindowsFormsUtility.SetControlBinding(txtCalorie, bindsource); 
            WindowsFormsUtility.SetControlBinding(lblDateDrafted, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDatePublished, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDateArchived, bindsource);
            WindowsFormsUtility.SetControlBinding(lblRecipeStatus, bindsource);
            this.Text = GetRecipeDesc();
            this.Shown += FrmRecipeDetail_Shown;
            SetButtonsEnabledBasedOnNewRecord();
        }
        
        private void LoadRecipeDirectionTable(int recipeid)
        {
            gRecipeDirection.Columns.Clear();
            dtRecipeDirection = RecipeDirection.LoadRecipeDirectionById(recipeid);
            gRecipeDirection.DataSource = dtRecipeDirection;
            WindowsFormsUtility.AddDeleteButtonToGrid(gRecipeDirection, deletecolname);
            //List<DataGridViewButtonColumn> lst = gRecipeDirection.Columns.[4];
            tabPage2.Text = "Steps";
            gRecipeDirection.Show();
            WindowsFormsUtility.FormatGridForEdit(gRecipeDirection, "RecipeDirection");
        }

        private void LoadRecipeIngredientTable(int recipeid)
        {
            gRecipeIngredient.Columns.Clear();
            dtRecipeIngredient = RecipeIngredient.LoadRecipeIngredientById(recipeid);
            gRecipeIngredient.DataSource = dtRecipeIngredient;
            dtIngredient = Recipe.GetIngredientList();
            WindowsFormsUtility.AddComboBoxToGrid(gRecipeIngredient, dtIngredient, "Ingredient", "IngredientName");
            dtMeasurement = Recipe.GetMeasurementList();
            WindowsFormsUtility.AddComboBoxToGrid(gRecipeIngredient, dtMeasurement, "Measurement", "MeasurementType");
            WindowsFormsUtility.AddDeleteButtonToGrid(gRecipeIngredient, deletecolname);
            tabPage1.Text = "Ingredients";
            gRecipeIngredient.Show();
            WindowsFormsUtility.FormatGridForEdit(gRecipeIngredient, "RecipeIngredient");
        }

        private string GetRecipeDesc()
        {
            string value = "Recipe - New Recipe";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtRecipe, "RecipeId");
            if (pkvalue > 0)
            {
                value = "Recipe - " + SQLUtility.GetValueFromFirstRowAsString(dtRecipe, "RecipeName");
            }
            return value;
        }

        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Save(dtRecipe);
                b = true;
                bindsource.ResetBindings(false);
                recipeid = (int)dtRecipe.Rows[0]["RecipeId"];
                this.Tag = recipeid;
                dtRecipe = Recipe.Load(recipeid);
                bindsource.DataSource = dtRecipe;
                SetButtonsEnabledBasedOnNewRecord();
                this.Text = GetRecipeDesc();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return b;
        }

        private void DeleteRecipe(DataTable dt)
        {
            var result = MessageBox.Show("Are you sure you want to delete this Recipe?", "Recipe", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Delete(dt);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        private void DeleteRecipeDirection(int rowindex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gRecipeDirection, rowindex, "RecipeDirectionId");
            if (id > 0)
            {
                var result = MessageBox.Show("Are you sure you want to delete this step?", "RecipeDirection", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
                Application.UseWaitCursor = true;
                try
                {
                    RecipeDirection.Delete(id);
                    LoadRecipeDirectionTable(recipeid);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "RecipeDirection");
                }
                finally
                {
                    Application.UseWaitCursor = false;
                }
            }
            else
            {
                if (id < gRecipeDirection.Rows.Count)
                {
                    gRecipeDirection.Rows.RemoveAt(rowindex);
                }
            }
        }

        private void DeleteRecipeIngredient(int rowindex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gRecipeIngredient, rowindex, "RecipeIngredientId");
            if (id > 0)
            {
                var result = MessageBox.Show("Are you sure you want to delete this ingredient?", "RecipeIngredient", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
                Application.UseWaitCursor = true;
                try
                {
                    RecipeIngredient.Delete(id);
                    LoadRecipeIngredientTable(recipeid);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "RecipeIngredient");
                }
                finally
                {
                    Application.UseWaitCursor = false;
                }
            }
            else
            {
                if (id < gRecipeIngredient.Rows.Count)
                {
                    gRecipeIngredient.Rows.RemoveAt(rowindex);
                }
            }
        }

        private bool SaveRecipeIngredient()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                foreach (DataRow r in dtRecipeIngredient.Rows)
                {
                    r["RecipeId"] = recipeid;
                }
                RecipeIngredient.Save(dtRecipeIngredient);
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

        private bool SaveRecipeDirection()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                foreach (DataRow r in dtRecipeDirection.Rows)
                {
                    r["RecipeId"] = recipeid;
                }
                RecipeDirection.Save(dtRecipeDirection);
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

        private void FrmRecipeDetail_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtRecipe) == true)
            {
                var res = MessageBox.Show($"Do you want to save changes to {this.Text} before closing the form?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        bool b = Save();
                        if (b == false)
                        {
                            e.Cancel = true;
                            this.Activate();
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();
                        break;
                }
            }
            if (SQLUtility.TableHasChanges(dtRecipeIngredient) == true)
            {
                var res = MessageBox.Show($"Do you want to save changes to {this.Text} Ingredinets before closing the form?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        bool b = SaveRecipeIngredient();
                        if (b == false)
                        {
                            e.Cancel = true;
                            this.Activate();
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();
                        break;
                }
            }
            if (SQLUtility.TableHasChanges(dtRecipeDirection) == true)
            {
                var res = MessageBox.Show($"Do you want to save changes to {this.Text} Steps before closing the form?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        bool b = SaveRecipeDirection();
                        if (b == false)
                        {
                            e.Cancel = true;
                            this.Activate();
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();
                        break;
                }
            }
        }

        private void SetButtonsEnabledBasedOnNewRecord()
        {
            bool b = recipeid == 0 ? false : true;
            btnDelete.Enabled = b;
            btnChangeStatus.Enabled = b;
            btnSaveRecipeIngredient.Enabled = b;
            btnSaveRecipeDirection.Enabled = b;
        }

        private void CheckValueIfInt(string text)
        {
            if (text != "")
            {
                bool b = WindowsFormsUtility.CheckCharacterIfNum(text);
                if (b == false)
                {
                    MessageBox.Show("Calorie must be an interger.");
                }
            }
        }

        private void TxtCalorie_TextChanged(object? sender, EventArgs e)
        {
            CheckValueIfInt(txtCalorie.Text);
        }

        private void GRecipeDirection_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int n = gRecipeDirection.Columns.Count - 1;
                if (e.ColumnIndex == n)
                {
                    int id = WindowsFormsUtility.GetIdFromGrid(gRecipeDirection, e.RowIndex, "RecipeDirectionId");
                    DeleteRecipeDirection(e.RowIndex);
                }
            }
        }

        private void GRecipeIngredient_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            //Button btn = (Button)(gRecipeIngredient.Rows[e.RowIndex].Cells[gRecipeIngredient.Columns.Count - 1]);                
            if (e.RowIndex >= 0)
            {

                //lstbtn.Add
                //
                //foreach (Button btn in gRecipeIngredient.Columns["Delete"])
                //{
                //
                //}

                //////////////private void GRecipeDirection_CellContentClick(object? sender, DataGridViewCellEventArgs e)
                //////////////{
                //////////////    int id = WindowsFormsUtility.GetIdFromGrid(gRecipeDirection, e.RowIndex, "RecipeDirectionId");
                //////////////    DeleteRecipeDirection(e.RowIndex);
                //////////////}

                int n = gRecipeIngredient.Columns.Count - 1;
                if (e.ColumnIndex == n)
                {
                    int id = WindowsFormsUtility.GetIdFromGrid(gRecipeIngredient, e.RowIndex, "RecipeIngredientId");
                    DeleteRecipeIngredient(e.RowIndex);
                }
            }
        }

        private void BtnSaveRecipeDirection_Click(object? sender, EventArgs e)
        {
            SaveRecipeDirection();
        }

        private void BtnSaveRecipeIngredient_Click(object? sender, EventArgs e)
        {
            SaveRecipeIngredient();
        }

        private void ChangeRecipeStatus()
        {
            string recipestatus = dtRecipe.Rows[0]["RecipeStatus"].ToString();

            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmChangeStatus), recipeid, recipestatus);
                this.Close();
            }
        }

        private void BtnChangeStatus_Click(object? sender, EventArgs e)
        {
            ChangeRecipeStatus();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            DeleteRecipe(dtRecipe);
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
    }
}
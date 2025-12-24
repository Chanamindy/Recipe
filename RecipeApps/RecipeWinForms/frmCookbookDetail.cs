using RecipeSystem;

namespace RecipeWinForms
{
    public partial class frmCookbookDetail : Form
    {
        DataTable dtCookbook;
        DataTable dtCookbookRecipe;
        DataTable dtUser;
        DataTable dtRecipe;
        BindingSource bindsource = new();
        int cookbookid = 0;
        bool cookbookstatus = true;
        string deletecolname = "deletecol";

        public frmCookbookDetail()
        {
            InitializeComponent();
            btnSaveRecipe.Click += BtnSaveRecipe_Click;
            btnSaveCookbook.Click += BtnSaveCookbook_Click;
            btnDelete.Click += BtnDelete_Click;
            gRecipe.CellContentClick += GRecipe_CellContentClick;
            txtCookbookPrice.TextChanged += TxtCookbookPrice_TextChanged;
            gRecipe.DataError += GRecipe_DataError;
            this.Shown += FrmCookbookDetail_Shown;
            this.FormClosing += FrmCookbookDetail_FormClosing;
        }

        private void FrmCookbookDetail_Shown(object? sender, EventArgs e)
        {
            LoadCookbookRecipes();
        }

        public void ShowForm(int cookbookidvalue)
        {
            cookbookid = cookbookidvalue;
            this.Tag = cookbookid;
            dtCookbook = Cookbook.LoadCookbookById(cookbookid);
            bindsource.DataSource = dtCookbook;
            dtUser = Cookbook.UserNameGet();

            if (cookbookid == 0)
            {
                dtCookbook.Rows.Add();
            }
            WindowsFormsUtility.SetControlBinding(txtCookbookName, bindsource);
            WindowsFormsUtility.SetListBinding(lstUserName, dtUser, dtCookbook, "UserStaff");
            WindowsFormsUtility.SetControlBinding(txtCookbookPrice, bindsource);
            WindowsFormsUtility.SetControlBinding(lblDateCreated, bindsource);
            WindowsFormsUtility.SetControlBinding(chkCookbookStatus, bindsource);
            this.Text = GetCookbookDesc();
            this.Shown += FrmCookbookDetail_Shown;
            SetSetButtonsEnabledBasedOnNewRecord();
        }

        private void LoadCookbookRecipes()
        {
            dtCookbookRecipe = Cookbook.LoadCookbookRecipesById(cookbookid);
            gRecipe.Columns.Clear();
            gRecipe.DataSource = dtCookbookRecipe;
            dtRecipe = Cookbook.GetRecipeList();
            WindowsFormsUtility.AddComboBoxToGrid(gRecipe, dtRecipe, "Recipe", "RecipeName");
            WindowsFormsUtility.AddDeleteButtonToGrid(gRecipe, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gRecipe, "CookbookRecipe");
            gRecipe.Show();
        }

        private string GetCookbookDesc()
        {
            string value = "Cookbook - New Cookbook";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtCookbook, "CookbookId");
            if (pkvalue > 0)
            {
                value = "Cookbook - " + SQLUtility.GetValueFromFirstRowAsString(dtCookbook, "CookbookName");
            }
            return value;
        }

        private void SetSetButtonsEnabledBasedOnNewRecord()
        {
            bool b = cookbookid == 0 ? false : true;
            btnDelete.Enabled = b;
            btnSaveRecipe.Enabled = b;
        }

        private void DeleteCookbookRecipe(int rowIndex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gRecipe, rowIndex, "CookbookRecipeId");
            if (id > 0)
            {
                var result = MessageBox.Show("Are you sure you want to delete this Recipe?", "CookbookRecipe", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
                Application.UseWaitCursor = true;
                try
                {
                    CookbookRecipe.Delete(id);
                    LoadCookbookRecipes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
                finally
                {
                    Application.UseWaitCursor = false;
                }
            }
            else 
            {
                if (id < gRecipe.Rows.Count)
                gRecipe.Rows.RemoveAt(rowIndex);
            }
        }
        private void Delete()
        {
            int id = SQLUtility.GetValueFromFirstRowAsInt(dtCookbook, "CookbookId");
            if (id > 0)
            {
                var result = MessageBox.Show("Are you sure you want to Delete this Cookbook?", "Cookbook", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
                Application.UseWaitCursor = true;
                try
                {
                    Cookbook.Delete(id);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
                finally
                {
                    Application.UseWaitCursor = false;
                }
            }
        }

        private bool Save()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                if (chkCookbookStatus.CheckState == CheckState.Unchecked)
                {
                    cookbookstatus = false;
                }
                dtCookbook.Rows[0]["CookbookStatus"] = cookbookstatus;
                Cookbook.Save(dtCookbook);
                b = true;
                bindsource.ResetBindings(false);
                cookbookid = (int)dtCookbook.Rows[0]["CookbookId"];
                this.Tag = cookbookid;
                dtCookbook = Cookbook.LoadCookbookById(cookbookid);
                bindsource.DataSource = dtCookbook;
                SetSetButtonsEnabledBasedOnNewRecord();
                this.Text = GetCookbookDesc();
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

        private bool SaveCookbookRecipe()
        {
            bool b = false;
            Application.UseWaitCursor = true;
            try
            {
                foreach (DataRow r in dtCookbookRecipe.Rows)
                {
                    r["CookbookId"] = cookbookid;
                }
                CookbookRecipe.SaveCookbookRecipe(dtCookbookRecipe);
                b = true;
                bindsource.ResetBindings(false);
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

        private void MessageValueMustBeAnInt(bool b, string columnname)
        {
            if (b == false)
            {
                MessageBox.Show(columnname + " must be an interger.");
            }
        }

        private void GRecipe_DataError(object? sender, DataGridViewDataErrorEventArgs e)
        {
            string columnname = gRecipe.Columns[e.ColumnIndex].Name;
            if (sender.ToString() != "")
            {
                bool b = SQLUtility.CheckValueIfInt(sender.ToString());
                MessageValueMustBeAnInt(b, columnname);
            }
        }

        private void TxtCookbookPrice_TextChanged(object? sender, EventArgs e)
        {
            if (txtCookbookPrice.Text != "")
            {
                bool b = SQLUtility.CheckValueIfInt(txtCookbookPrice.Text);
                MessageValueMustBeAnInt(b, "CookbookPrice");
            }
        }

        private void FrmCookbookDetail_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtCookbook) == true)
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
            if (SQLUtility.TableHasChanges(dtCookbookRecipe) == true)
            {
                var res = MessageBox.Show($"Do you want to save changes to {this.Text} Recipe before closing the form?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        bool b = SaveCookbookRecipe();
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

        private void GRecipe_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int id = WindowsFormsUtility.GetIdFromGrid(gRecipe, e.RowIndex, "CookbookRecipeId");
                if (id > 0)
                {
                    DeleteCookbookRecipe(e.RowIndex);
                }
            }
        }
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSaveCookbook_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void BtnSaveRecipe_Click(object? sender, EventArgs e)
        {
            SaveCookbookRecipe();
        }
    }
}
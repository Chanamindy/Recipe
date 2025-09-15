using RecipeSystem;
using System.Data.SqlClient;

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
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookListGet");
            SQLUtility.SetParamValue(cmd, "@CookbookId", cookbookid);
            dtCookbook = SQLUtility.GetDataTable(cmd);
            bindsource.DataSource = dtCookbook;

            SqlCommand cmdUser = SQLUtility.GetSqlCommand("UserNameGet");
            SQLUtility.SetParamValue(cmdUser, "@All", 1);
            dtUser = SQLUtility.GetDataTable(cmdUser);

            if (cookbookid == 0)
            {
                dtCookbook.Rows.Add();
            }
            WindowsFormsUtility.SetControlBinding(txtCookbookName, bindsource);
            WindowsFormsUtility.SetListBinding(lstUserName, dtUser, dtCookbook, "UserStaff");
            WindowsFormsUtility.SetControlBinding(txtCookbookPrice, bindsource);
            WindowsFormsUtility.SetControlBinding(dtpDateCreated, bindsource);
            WindowsFormsUtility.SetControlBinding(chkCookbookStatus, bindsource);
            this.Text = GetCookbookDesc();
            this.Shown += FrmCookbookDetail_Shown;
        }

        private void LoadCookbookRecipes()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookRecipesGet");
            SQLUtility.SetParamValue(cmd, "@CookbookId", cookbookid);
            dtCookbookRecipe = SQLUtility.GetDataTable(cmd);
            gRecipe.Columns.Clear();
            gRecipe.DataSource = dtCookbookRecipe;
            
            SqlCommand cmdRecipe = SQLUtility.GetSqlCommand("RecipeGet");
            SQLUtility.SetParamValue(cmdRecipe, "@All", 1);
            SQLUtility.SetParamValue(cmdRecipe, "@IncludeBlank", 1);
            DataTable dtRecipe = SQLUtility.GetDataTable(cmdRecipe);
            WindowsFormsUtility.AddComboBoxToGrid(gRecipe, dtRecipe, "Recipe", "RecipeName");

            WindowsFormsUtility.AddDeleteButtonToGrid(gRecipe, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gRecipe, "CookbookRecipe");

            gRecipe.Show();
            WindowsFormsUtility.FormatGridForEdit(gRecipe, "CookbookRecipe");
        }

        private string GetCookbookDesc()
        {
            string value = "New Cookbook";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtCookbook, "CookbookId");
            if (pkvalue > 0)
            {
                value = SQLUtility.GetValueFromFirstRowAsString(dtCookbook, "CookbookName");
            }
            return value;
        }

        private void DeleteCookbookRecipe(int rowIndex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gRecipe, rowIndex, "CookbookRecipeId");
            if (id > 0)
            {
                try
                {
                    CookbookRecipe.Delete(id);
                    LoadCookbookRecipes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (id < gRecipe.Rows.Count)
            {
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
            DeleteCookbookRecipe(e.RowIndex);
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
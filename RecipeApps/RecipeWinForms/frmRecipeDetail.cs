namespace RecipeWinForms
{
    public partial class frmRecipeDetail : Form
    {
        DataTable dtRecipe;
        public frmRecipeDetail()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
        }
        
        public void ShowForm(int RecipeId)
        {
            dtRecipe = Recipe.Load(RecipeId);
            if (RecipeId == 0)
            {
                dtRecipe.Rows.Add();
            }
            DataTable dtCuisine = Recipe.GetCuisineList();
            SQLUtility.DebugPrintDataTable(dtCuisine);
            DataTable dtUserStaff = Recipe.GetUserStaffList();
            SQLUtility.DebugPrintDataTable(dtUserStaff);
            WindowsFormsUtility.SetListBinding(lstCuisineType, dtCuisine, dtRecipe, "Cuisine");
            WindowsFormsUtility.SetListBinding(lstUserName, dtUserStaff, dtRecipe, "UserStaff");
            WindowsFormsUtility.SetControlBinding(txtRecipeName, dtRecipe);
            WindowsFormsUtility.SetControlBinding(txtCalorie, dtRecipe); 
            WindowsFormsUtility.SetControlBinding(dtpDateDrafted, dtRecipe);
            WindowsFormsUtility.SetControlBinding(lblDatePublished, dtRecipe);
            WindowsFormsUtility.SetControlBinding(lblDateArchived, dtRecipe);
            WindowsFormsUtility.SetControlBinding(lblRecipeStatus, dtRecipe);
            this.Show();
        }

        private void Save()
        {
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Save(dtRecipe);
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

        private void Delete()
        {
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Delete(dtRecipe);
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

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
    }
}

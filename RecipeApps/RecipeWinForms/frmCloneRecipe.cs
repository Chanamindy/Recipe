namespace RecipeWinForms
{
    public partial class frmCloneRecipe : Form
    {
        DataTable dtRecipe;
        BindingSource bindsource = new();

        public frmCloneRecipe()
        {
            InitializeComponent();
            BindData();
            btnClone.Click += BtnClone_Click;
        }

        private void BindData()
        {
            dtRecipe = Recipe.Load(0, true, true);
            bindsource.DataSource = dtRecipe;
            WindowsFormsUtility.BindDataToSingleList(lstRecipe, dtRecipe, "RecipeName", "RecipeId");
        }

        private void CloneRecipe()
        {
            int recipeid = WindowsFormsUtility.GetIdFromComboBox(lstRecipe);
            DataTable dtnew = Recipe.CloneRecipe(recipeid);
            int clonerecipeid = (int)dtnew.Rows[0]["RecipeId"];
            
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeDetail), clonerecipeid);
                this.Close();
            }
        }

        private void BtnClone_Click(object? sender, EventArgs e)
        {
            CloneRecipe();            
        }
    }
}

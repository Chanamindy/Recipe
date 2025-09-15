namespace RecipeWinForms
{
    public partial class frmRecipeSearch : Form
    {
        public frmRecipeSearch()
        {
            InitializeComponent();
            btnSearch.Click += BtnSearch_Click;
            btnNew.Click += BtnNew_Click;

            gRecipe.CellDoubleClick += GRecipe_CellDoubleClick;
            WindowsFormsUtility.FormatGridForSearchResults(gRecipe, "Recipe");
        }
        
        private void SearchRecipe(string recipe)
        {
            DataTable dt = Recipe.SearchRecipe(recipe);
            gRecipe.DataSource = dt;
            gRecipe.Columns["RecipeId"].Visible = false;
        }

        private void ShowRecipeDetailsForm(int rowindex)
        {
            int Id = 0;
            if (rowindex > -1)
            {
                Id = (int)gRecipe.Rows[rowindex].Cells["RecipeId"].Value;
            }
            frmRecipeDetail frm = new frmRecipeDetail();
            frm.LoadForm(Id);
        }

        private void GRecipe_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeDetailsForm(e.RowIndex);
        }

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            SearchRecipe(txtRecipeSearch.Text);
        }

        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ShowRecipeDetailsForm(-1);
        }
    }
}

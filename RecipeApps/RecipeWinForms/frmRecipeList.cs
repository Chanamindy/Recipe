namespace RecipeWinForms
{
    public partial class frmRecipeList : Form
    {
        DataTable dtRecipe;

        public frmRecipeList()
        {
            InitializeComponent();
            BindData();
            this.Activated += FrmRecipeList_Activated;
            gRecipeList.CellDoubleClick += GRecipeList_CellDoubleClick;
            gRecipeList.KeyDown += GRecipeList_KeyDown; ;
            btnNewRecipe.Click += BtnNewRecipe_Click;
        }

        private void FrmRecipeList_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        public void BindData()
        {
            dtRecipe = Recipe.RecipeListSummaryGet();
            gRecipeList.DataSource = dtRecipe;
            WindowsFormsUtility.FormatGridForSearchResults(gRecipeList, "Recipe");
            //gRecipeList.Show();
        }

        private void ShowRecipeDetailsForm(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = WindowsFormsUtility.GetIdFromGrid(gRecipeList, rowindex, "RecipeId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeDetail), id);
            }
        }

        private void GRecipeList_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ShowRecipeDetailsForm(gRecipeList.CurrentCell.RowIndex);
                e.SuppressKeyPress = true;
            }
        }

        private void GRecipeList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            ShowRecipeDetailsForm(e.RowIndex);
        }

        private void BtnNewRecipe_Click(object? sender, EventArgs e)
        {
            ShowRecipeDetailsForm(-1);
        }
    }
}
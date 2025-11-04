namespace RecipeWinForms
{
    public partial class frmMealList : Form
    {
        public frmMealList()
        {
            InitializeComponent();
            BindData();
        }

        private void BindData()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("MealListGet");
            DataTable dt = SQLUtility.GetDataTable(cmd);
            gMealList.DataSource = dt;
            WindowsFormsUtility.FormatGridForSearchResults(gMealList, "Meal");
            gMealList.Show();
        }
    }
}

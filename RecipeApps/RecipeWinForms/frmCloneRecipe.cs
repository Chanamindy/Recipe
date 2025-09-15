using System.Data.SqlClient;

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
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            SQLUtility.SetParamValue(cmd, "@IncludeBlank", 1);
            dtRecipe = SQLUtility.GetDataTable(cmd);

            bindsource.DataSource = dtRecipe;

            lstRecipe.DataSource = dtRecipe;
            lstRecipe.DisplayMember = "RecipeName";
            lstRecipe.ValueMember = "RecipeId";
        }

        private void CloneRecipe()
        {
            int recipeid = WindowsFormsUtility.GetIdFromComboBox(lstRecipe);
            SqlCommand cmd = SQLUtility.GetSqlCommand("CloneRecipe");
            SQLUtility.SetParamValue(cmd, "@RecipeId", recipeid);
            DataTable dtnew = SQLUtility.GetDataTable(cmd);

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

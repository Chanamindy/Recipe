using RecipeSystem;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            BindData();
            btnRecipeList.Click += BtnRecipeList_Click;
            btnMealList.Click += BtnMealList_Click;
            btnCookbookList.Click += BtnCookbookList_Click;
        }

        private void BindData()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("DashboardSummaryGet");
            DataTable dt = SQLUtility.GetDataTable(cmd);
            gMain.DataSource = dt;
            gMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            WindowsFormsUtility.FormatGridForSearchResults(gMain, null);
            gMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void ShowForm(Type frmtype, int pkvalue = 0)
        {
            Form? newfrm = null;
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                if (frmtype == typeof(frmRecipeList))
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmRecipeList));
                }
                else if (frmtype == typeof(frmMealList))
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmMealList));
                }
                else if (frmtype == typeof(frmCookbookList))
                {
                    ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbookList));
                }
            }
        }

        private void BtnCookbookList_Click(object? sender, EventArgs e)
        {
            ShowForm(typeof(frmCookbookList));
        }

        private void BtnMealList_Click(object? sender, EventArgs e)
        {
            ShowForm(typeof(frmMealList));
        }

        private void BtnRecipeList_Click(object? sender, EventArgs e)
        {
            ShowForm(typeof(frmRecipeList));
        }
    }
}
namespace RecipeWinForms
{
    public partial class frmCookbookList : Form
    {
        public frmCookbookList()
        {
            InitializeComponent();
            BindData();
            this.Activated += FrmCookbookList_Activated;
            gCookbookList.CellDoubleClick += GCookbookList_CellDoubleClick;
            btnNewCookbook.Click += BtnNewCookbook_Click;
        }

        private void FrmCookbookList_Activated(object? sender, EventArgs e)
        {
            BindData();
        }

        private void BindData()
        {
            DataTable dt = Cookbook.CookbookListSummaryGet();
            gCookbookList.DataSource = dt;
            WindowsFormsUtility.FormatGridForSearchResults(gCookbookList, "Cookbook");
        }

        private void OpenForm(int rowindex)
        {
            int CookbookId = 0;
            if (rowindex > -1)
            {
                CookbookId = WindowsFormsUtility.GetIdFromGrid(gCookbookList, rowindex, "CookbookId");
            }
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbookDetail), CookbookId);
            }
        }

        private void GCookbookList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            OpenForm(e.RowIndex);
        }

        private void BtnNewCookbook_Click(object? sender, EventArgs e)
        {
            OpenForm(-1);
        }
    }
}

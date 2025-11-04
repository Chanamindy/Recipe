namespace RecipeWinForms
{
    public partial class frmAutoCreateCookbook : Form
    {
        BindingSource bindsource = new();

        public frmAutoCreateCookbook()
        {
            InitializeComponent();
            BindData();
            btnCreateCookbook.Click += BtnCreateCookbook_Click;
        }

        private void BindData()
        {
            DataTable dtUser = new();
            dtUser = Cookbook.UserNameGet();
            bindsource.DataSource = dtUser;
            WindowsFormsUtility.BindDataToSingleList(lstUserStaff, dtUser, "UserName", "UserStaffId");
        }

        private void CreateCookbook()
        {
            bindsource.ResetBindings(false); 
            int userstaffid = WindowsFormsUtility.GetIdFromComboBox(lstUserStaff);
            int cookbookid = Cookbook.AutoCreateCookBook(userstaffid);
            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbookDetail), cookbookid);
                this.Close();
            }
        }

        private void BtnCreateCookbook_Click(object? sender, EventArgs e)
        {
            try 
            {
                CreateCookbook();
            }
            catch (Exception ex)
            {
                string message = "";
                if (ex.Message == "There is no row at position 0.")
                {
                    message = "A cookbook can't be created for this user since there are no recipes for this user.";
                }
                else if (ex.Message == "CookBook CookBook Name must be unique.")
                {
                    message = "There is already an auto-created cookbook for this user.";
                }
                MessageBox.Show(message, Application.ProductName);
            }
        }
    }
}

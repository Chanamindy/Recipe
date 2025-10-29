using CPUFramework;
using RecipeSystem;

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
            dtUser = UserNameGet();
            bindsource.DataSource = dtUser;
            WindowsFormsUtility.BindDataToSingleList(lstUserStaff, dtUser, "UserName", "UserStaffId");
        }

        private void CreateCookbook()
        {
            bindsource.ResetBindings(false); 
            int userstaffid = WindowsFormsUtility.GetIdFromComboBox(lstUserStaff);
            int cookbookid = AutoCreateCookBook(userstaffid);
            SqlCommand cmd = SQLUtility.GetSqlCommand("AutoCreateCookbook");
            SQLUtility.SetParamValue(cmd, "@UserStaffId", userstaffid);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            //int cookbookid = (int)dt.Rows[0]["CookbookId"];

            //cookbookid = Cookbook.AutoCreateCookbook(lstUserStaff);

            if (this.MdiParent != null && this.MdiParent is frmMain)
            {
                ((frmMain)this.MdiParent).OpenForm(typeof(frmCookbookDetail), cookbookid);
                this.Close();
            }
        }

        public static DataTable UserNameGet()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("UserNameGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            SQLUtility.SetParamValue(cmd, "@IncludeBlank", 1);
            DataTable dtUser = SQLUtility.GetDataTable(cmd);
            return dtUser;
        }

        public static int AutoCreateCookBook(int userstaffid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("AutoCreateCookbook");
            SQLUtility.SetParamValue(cmd, "@UserStaffId", userstaffid);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            int cookbookid = (int)dt.Rows[0]["CookbookId"];
            return cookbookid;
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

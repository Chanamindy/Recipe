using RecipeWinForms.Properties;
using System.Configuration;

namespace RecipeWinForms
{
    public partial class frmLogin : Form
    {
        bool loginsuccess = false;

        public frmLogin()
        {
            InitializeComponent();
            btnOk.Click += BtnOk_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        public bool ShowLogin()
        {
            txtUserName.Text = Settings.Default.userid;
            this.ShowDialog();
            return loginsuccess;
        }
        
        private void BtnOk_Click(object? sender, EventArgs e)
        {
            try
            {
                string connectionstring = ConfigurationManager.ConnectionStrings["liveconn"].ConnectionString;
                DBManager.SetConnectionString(connectionstring, true, txtUserName.Text, txtPassword.Text);
                loginsuccess = true;
                Settings.Default.userid = txtUserName.Text;
                Settings.Default.Save();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Invalid Login. Try Again.", Application.ProductName);
            }
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPUFramework;

namespace RecipeWinForms
{
    public partial class frmRecipeDetail : Form
    {
        public frmRecipeDetail()
        {
            InitializeComponent();
        }

        public void ShowForm(int RecipeId)
        {
            string sql = "select r.RecipeName, c.CuisineType, r.Calorie, us.UserFirstName, us.UserLastName, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus from Recipe r join Cuisine c on r.CuisineId = c.CuisineId join UserStaff us on r.UserStaffId = us.UserStaffId where r.RecipeId =" + RecipeId;
            DataTable dt = SQLUtility.GetDataTable(sql);
            lblRecipeName.DataBindings.Add("Text", dt, "RecipeName");
            lblCuisineType.DataBindings.Add("Text", dt, "CuisineType");
            lblCalorie.DataBindings.Add("Text", dt, "Calorie");
            lblUserFirstName.DataBindings.Add("Text", dt, "UserFirstName");
            lblUserLastName.DataBindings.Add("Text", dt, "UserLastName");
            lblDateDrafted.DataBindings.Add("Text", dt, "DateDrafted");
            lblDatePublished.DataBindings.Add("Text", dt, "DatePublished");
            lblDateArchived.DataBindings.Add("Text", dt, "DateArchived");
            lblRecipeStatus.DataBindings.Add("Text", dt, "RecipeStatus");
            this.Show();
        }
    }
}

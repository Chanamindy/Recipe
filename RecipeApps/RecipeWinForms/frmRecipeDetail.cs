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
using CPUWindowsFormsFramework;

namespace RecipeWinForms
{
    public partial class frmRecipeDetail : Form
    {
        DataTable dtRecipe;
        public frmRecipeDetail()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
        }
        
        public void ShowForm(int RecipeId)
        {
            string sql = "select r.*, c.CuisineType, us.UserFirstName, us.UserLastName from Recipe r join Cuisine c on r.CuisineId = c.CuisineId join UserStaff us on r.UserStaffId = us.UserStaffId where r.RecipeId = " + RecipeId;
            dtRecipe = SQLUtility.GetDataTable(sql);
            if (RecipeId == 0)
            {
                dtRecipe.Rows.Add();
            }
            DataTable dtCuisine = SQLUtility.GetDataTable("select CuisineId, CuisineType from Cuisine");
            SQLUtility.DebugPrintDataTable(dtCuisine);
            DataTable dtUserStaff = SQLUtility.GetDataTable("select UserStaffId, UserFirstName, UserLastName from UserStaff");
            SQLUtility.DebugPrintDataTable(dtUserStaff);
            WindowsFormsUtility.SetListBinding(lstCuisineType, dtCuisine, dtRecipe, "Cuisine");
            WindowsFormsUtility.SetListBinding(lstUserFirstName, dtUserStaff, dtRecipe, "UserStaff");
            WindowsFormsUtility.SetListBinding(lstUserLastName, dtUserStaff, dtRecipe, "UserStaff");
            WindowsFormsUtility.SetControlBinding(txtRecipeName, dtRecipe);
            WindowsFormsUtility.SetControlBinding(txtCalorie, dtRecipe); 
            WindowsFormsUtility.SetControlBinding(dtpDateDrafted, dtRecipe);
            WindowsFormsUtility.SetControlBinding(lblDatePublished, dtRecipe);
            WindowsFormsUtility.SetControlBinding(lblDateArchived, dtRecipe);
            WindowsFormsUtility.SetControlBinding(lblRecipeStatus, dtRecipe);
            this.Show();
        }

        private void Save()
        {
            SQLUtility.DebugPrintDataTable(dtRecipe);
            DataRow r = dtRecipe.Rows[0];
            int id = (int)r["RecipeId"];
            string sql = "";

            if (id > 0)
            {
                sql = string.Join(Environment.NewLine, $"update Recipe set",
                $"CuisineId = '{r["CuisineId"]}',",
                $"UserStaffId = '{r["UserStaffId"]}',",
                $"RecipeName = '{r["RecipeName"]}',",
                $"Calorie = '{r["Calorie"]}',",
                $"DateDrafted = '{r["DateDrafted"]}'",
                $"where RecipeId = {r["RecipeId"]}");
            }
            else
            {
                sql = "insert Recipe(CuisineId, UserStaffId, RecipeName, Calorie, DateDrafted)";
                sql += $"select '{r["CuisineId"]}', '{r["UserStaffId"]}', '{r["RecipeName"]}', '{r["Calorie"]}', '{r["DateDrafted"]}'";
            }

            SQLUtility.ExecuteSQL(sql);
        }

        private void Delete()
        {
            int id = (int)dtRecipe.Rows[0]["RecipeId"];
            string sql = "delete Recipe where RecipeId = " + id;
            SQLUtility.ExecuteSQL(sql);
            this.Close();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
    }
}

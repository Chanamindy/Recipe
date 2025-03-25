using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPUFramework;

namespace RecipeSystem
{
    public class Recipe
    {
        public static DataTable SearchRecipe(string recipe)
        {
            string sql = "select r.RecipeId, r.RecipeName from Recipe r where r.RecipeName like '%" + recipe + "%'";
            return SQLUtility.GetDataTable(sql);
        }

        public static DataTable Load(int RecipeId)
        {
            string sql = "select r.*, c.CuisineType, us.UserFirstName, us.UserLastName from Recipe r join Cuisine c on r.CuisineId = c.CuisineId join UserStaff us on r.UserStaffId = us.UserStaffId where r.RecipeId = " + RecipeId;
            return SQLUtility.GetDataTable(sql);
        }

        public static DataTable GetCuisineList()
        {
            return SQLUtility.GetDataTable("select CuisineId, CuisineType from Cuisine");
        }

        public static DataTable GetUserStaffList()
        {
            return SQLUtility.GetDataTable("select UserName = concat(UserFirstName, ' ', UserLastName), UserStaffId, UserFirstName, UserLastName from UserStaff");
        }

        public static void Save(DataTable dtRecipe)
        {
            //SQLUtility.DebugPrintDataTable(dtRecipe);
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

        public static void Delete(DataTable dtRecipe)
        {
            int id = (int)dtRecipe.Rows[0]["RecipeId"];
            string sql = "delete Recipe where RecipeId = " + id;
            SQLUtility.ExecuteSQL(sql);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            cmd.Parameters["@RecipeName"].Value = recipe;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable Load(int RecipeId)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            cmd.Parameters["@RecipeId"].Value = RecipeId;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetCuisineList()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("CuisineGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetUserStaffList()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("UserNameGet");
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void Save(DataTable dtRecipe)
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
                $"where RecipeId = '{r["RecipeId"]}'");
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

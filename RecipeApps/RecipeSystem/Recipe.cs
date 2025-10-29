using System.Data;
using System.Data.SqlClient;
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

        //public static DataTable Load(int RecipeId = 0, bool all = false, bool blank = false)
        //{
        //    DataTable dt = new();
        //    SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
        //    SQLUtility.SetParamValue(cmd, "@RecipeId", RecipeId);
        //    SQLUtility.SetParamValue(cmd, "@All", all);
        //    SQLUtility.SetParamValue(cmd, "@IncludeBlank", blank);
        //    dt = SQLUtility.GetDataTable(cmd);
        //    return dt;
        //}

        
        //public static DataTable GetCuisineList(bool includeblank = false)
        //{
        //    DataTable dt = new();
        //    SqlCommand cmd = SQLUtility.GetSqlCommand("CuisineGet");
        //    cmd.Parameters["@All"].Value = 1;
        //    if (includeblank == true)
        //    {
        //        cmd.Parameters["@IncludeBlank"].Value = 1;
        //    }
        //    dt = SQLUtility.GetDataTable(cmd);
        //    return dt;
        //}

        //public static DataTable GetUserStaffList(bool includeblank = false)
        //{
        //    DataTable dt = new();
        //    SqlCommand cmd = SQLUtility.GetSqlCommand("UserNameGet");
        //    cmd.Parameters["@All"].Value = 1;
        //    if (includeblank == true)
        //    {
        //        cmd.Parameters["@IncludeBlank"].Value = 1;
        //    }
        //    dt = SQLUtility.GetDataTable(cmd);
        //    return dt;
        //}

        public static DataTable GetIngredientList()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("IngredientGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetMeasurementList()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSqlCommand("MeasurementGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void Save(DataTable dtRecipe)
        {
            if (dtRecipe.Rows.Count == 0)
            {
                throw new Exception("Cannot call RecipeSave method because there are no rows in the table.");
            }

            DataRow r = dtRecipe.Rows[0];
            SQLUtility.SaveDataRow(r, "RecipeUpdate");
        }

        public static void Delete(DataTable dtRecipe)
        {
            int id = (int)dtRecipe.Rows[0]["RecipeId"];
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeDelete");
            SQLUtility.SetParamValue(cmd, "@RecipeId", id);
            SQLUtility.ExecuteSQL(cmd);
        }

        public static void ChangeRecipeStatus(int recipeid, string newstatus)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("ChangeRecipeStatus");
            SQLUtility.SetParamValue(cmd, "@RecipeId", recipeid);
            SQLUtility.SetParamValue(cmd, "@NewRecipeStatus", newstatus);
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
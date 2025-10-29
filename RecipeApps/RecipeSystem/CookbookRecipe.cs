using CPUFramework;
//using CPUWindowsFormsFramework;
using System.Data;
using System.Data.SqlClient;

namespace RecipeSystem
{
    public class CookbookRecipe
    {
        public static void Delete(int id)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookRecipeDelete");
            SQLUtility.SetParamValue(cmd, "@CookbookRecipeId", id);
            SQLUtility.ExecuteSQL(cmd);
        }

        public static void SaveCookbookRecipe(DataTable dtCookbookRecipe)
        {
            if (dtCookbookRecipe.Rows.Count == 0)
            {
                throw new Exception("Cannot call CookbookRecipeSave method because there are no rows in the table.");
            }
            DataRow r = dtCookbookRecipe.Rows[0];
            SQLUtility.SaveDataTable(dtCookbookRecipe, "CookbookRecipeUpdate");
        }
    }
}
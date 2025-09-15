using CPUFramework;
using System.Data;
using System.Data.SqlClient;

namespace RecipeSystem
{
    public class RecipeIngredient
    {
        public static DataTable LoadRecipeIngredientById(int pkvalue)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeIngredientsGet");
            SQLUtility.SetParamValue(cmd, "@RecipeId", pkvalue);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void Delete(int id)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeIngredientDelete");
            SQLUtility.SetParamValue(cmd, "@RecipeIngredientId", id);
            SQLUtility.ExecuteSQL(cmd);
        }

        public static void Save(DataTable dtRecipeIngredient)
        {
            if (dtRecipeIngredient.Rows.Count == 0)
            {
                throw new Exception("Cannot call RecipeIgredientSave method because there are no rows in the table.");
            }

            foreach (DataRow r in dtRecipeIngredient.Rows)
            {
                SQLUtility.SaveDataRow(r, "RecipeIngredientUpdate");
            }
        }
    }
}

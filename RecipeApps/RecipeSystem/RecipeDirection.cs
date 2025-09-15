using CPUFramework;
using System.Data;
using System.Data.SqlClient;

namespace RecipeSystem
{
    public class RecipeDirection
    {
        public static DataTable LoadRecipeDirectionById(int recipeid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeDirectionsGet");
            SQLUtility.SetParamValue(cmd, "@RecipeId", recipeid);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void Delete(int id)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeDirectionDelete");
            SQLUtility.SetParamValue(cmd, "@RecipeDirectionId", id);
            SQLUtility.ExecuteSQL(cmd);
        }

        public static void Save(DataTable dtRecipeDirection)
        {
            if (dtRecipeDirection.Rows.Count == 0)
            {
                throw new Exception("Cannot call RecipeDirectionSave method because there are no rows in the table.");
            }

            foreach (DataRow r in dtRecipeDirection.Rows)
            {
                SQLUtility.SaveDataRow(r, "RecipeDirectionUpdate");
            }
        }
    }
}

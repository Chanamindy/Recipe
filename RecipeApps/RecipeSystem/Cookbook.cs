using CPUFramework;
using System.Data;
using System.Data.SqlClient;

namespace RecipeSystem
{
    public class Cookbook
    {
        public static void Save(DataTable dtCookbook)
        {
            if (dtCookbook.Rows.Count == 0)
            {
                throw new Exception("Cannot call CookbookSave method because there are no rows in the table.");
            }
            DataRow r = dtCookbook.Rows[0];
            SQLUtility.SaveDataRow(r, "CookbookUpdate");
        }

        public static void Delete(int cookbookid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookDelete");
            SQLUtility.SetParamValue(cmd, "@CookbookId", cookbookid);
            SQLUtility.ExecuteSQL(cmd);
        }

        public static DataTable UserNameGet(bool includeblank = false)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("UserNameGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            SQLUtility.SetParamValue(cmd, "@IncludeBlank", 1);
            DataTable dtUser = SQLUtility.GetDataTable(cmd);
            return dtUser;
        }

        public static DataTable LoadCookbookById(int cookbookid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookListGet");
            SQLUtility.SetParamValue(cmd, "@CookbookId", cookbookid);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable CookbookListSummaryGet()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookListSummaryGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable LoadCookbookRecipesById(int cookbookid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("CookbookRecipesGet");
            SQLUtility.SetParamValue(cmd, "@CookbookId", cookbookid);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static DataTable GetRecipeList(bool includeblank = false)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            if (includeblank == true)
            {
                SQLUtility.SetParamValue(cmd, "@IncludeBlank", 1);
            }
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static int AutoCreateCookBook(int userstaffid)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("AutoCreateCookbook");
            SQLUtility.SetParamValue(cmd, "@UserStaffId", userstaffid);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            int cookbookid = (int)dt.Rows[0]["CookbookId"];
            return cookbookid;
        }
    }
}
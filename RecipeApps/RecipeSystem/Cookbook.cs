using CPUFramework;
//using CPUWindowsFormsFramework;
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

        public static DataTable UserNameGet()
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("UserNameGet");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            SQLUtility.SetParamValue(cmd, "@IncludeBlank", 1);
            DataTable dtUser = SQLUtility.GetDataTable(cmd);
            return dtUser;
        }

        //public static int AutoCreateCookBook(ComboBox lstUserStaff)
        //{
        //    int userstaffid = WindowsFormsUtility.GetIdFromComboBox(lstUserStaff);
        //    SqlCommand cmd = SQLUtility.GetSqlCommand("AutoCreateCookbook");
        //    SQLUtility.SetParamValue(cmd, "@UserStaffId", userstaffid);
        //    DataTable dt = SQLUtility.GetDataTable(cmd);
        //    int cookbookid = (int)dt.Rows[0]["CookbookId"];
        //    return cookbookid;
        //}
    }
}
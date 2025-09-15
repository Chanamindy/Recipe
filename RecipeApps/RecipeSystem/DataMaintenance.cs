using CPUFramework;
using System.Data;
using System.Data.SqlClient;

namespace RecipeSystem
{
    public class DataMaintenance
    {
        public static DataTable DataListGet(string tablename)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(tablename + "Get");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            DataTable dt = SQLUtility.GetDataTable(cmd);
            return dt;
        }

        public static void DeleteRow(string tablename, int pkvalue)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand(tablename + "Delete");
            SQLUtility.SetParamValue(cmd, "@" + tablename + "Id", pkvalue);
            SQLUtility.ExecuteSQL(cmd);
        }
    }
}
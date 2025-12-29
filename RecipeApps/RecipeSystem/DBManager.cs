using CPUFramework;

namespace RecipeSystem
{
    public class DBManager
    {
        public static void SetConnectionString(string connectionstring, bool tryopen)
        {
            SQLUtility.SetConnectionString(connectionstring, tryopen);
        }
    }
}

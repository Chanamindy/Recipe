namespace RecipeTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString("Server=.\\SQLExpress;Database=RecipeWebsiteDB;Trusted_Connection=true");
            //"Server=tcp:cmherszaft.database.windows.net,1433;Initial Catalog=RecipeWebsiteDB;Persist Security Info=False;User ID=Chanacpuadmin;Password=Chanaadmin412;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        }

        private string GetValueOfRowAndColumnString(string sql, string column)
        {
            DataTable dt = SQLUtility.GetDataTable(sql);
            return dt.Rows[0][column].ToString();
        }

        [Test]
        public void EditRecipeDateDrafted()
        {
            int recipeid = SQLUtility.GetFirstColumnFirstRowValue("select recipeid from recipe");
            Assume.That(recipeid > 0, "No recipes in the database, can't run the test.");
            DataTable dtdatedrafted = SQLUtility.GetDataTable("select datedrafted from recipe where recipeid = " + recipeid);
            DateTime datedrafted = (DateTime)dtdatedrafted.Rows[0]["DateDrafted"];
            TestContext.WriteLine("The datedrafted for the recipe with recipeid = " + recipeid + " is " + datedrafted);
            datedrafted = { 2 - 2 - 2022};
            TestContext.WriteLine("Change the datedrafted to " + datedrafted);

            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["DateDrafted"] = datedrafted;
            Recipe.Save(dt);

            DataTable newdtdatedrafted = SQLUtility.GetDataTable("select datedrafted from recipe where recipeid = " + recipeid);
            DateTime newdatedrafted = (DateTime)newdtdatedrafted.Rows[0]["DateDrafted"];
            Assert.That(newdatedrafted == datedrafted, "The datedrafted for the recipe with the recipeid = " + recipeid + " wasn't changed to " + datedrafted);
            TestContext.WriteLine("The datedrafted for the recipe with the recipeid = " + recipeid + " was changed to " + datedrafted);
        }

        [Test]
        public void EditRecipeCalories()
        {
            int recipeid = SQLUtility.GetFirstColumnFirstRowValue("select recipeid from recipe");
            Assume.That(recipeid > 0, "No recipes in the database, can't run the test.");
            int calorie = SQLUtility.GetFirstColumnFirstRowValue("select calorie from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("The calories for the recipe with recipeid = " + recipeid + " is " + calorie);
            calorie = calorie + 10;
            TestContext.WriteLine("Change the caloies to " + calorie);

            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["Calorie"] = calorie;
            Recipe.Save(dt);

            int newcalorie = SQLUtility.GetFirstColumnFirstRowValue("select calorie from recipe where recipeid = " + recipeid);
            Assert.That(newcalorie == calorie, "The calories for the recipe with the recipeid = " + recipeid + " wasn't changed to " + calorie);
            TestContext.WriteLine("The calories for the recipe with the recipeid = " + recipeid + " was changed to " + calorie);
        }

        [Test]
        public void EditRecipeName()
        {
            int recipeid = SQLUtility.GetFirstColumnFirstRowValue("select recipeid from recipe");
            Assume.That(recipeid > 0, "No recipes in the database, can't run the test.");
            string recipename = GetValueOfRowAndColumnString("select recipename from recipe where recipeid = " + recipeid, "RecipeName");
            TestContext.WriteLine("The recipename for the recipe with recipeid = " + recipeid + " is " + recipename);
            recipename = recipename + "-changed";
            TestContext.WriteLine("Change the recipename to " + recipename);

            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["RecipeName"] = recipename;
            Recipe.Save(dt);

            string newrecipename = GetValueOfRowAndColumnString("select recipename from recipe where recipeid = " + recipeid, "RecipeName");
            Assert.That(newrecipename == recipename, "The recipename for the recipe with the recipeid = " + recipeid + " wasn't changed to " + recipename);
            TestContext.WriteLine("The recipename for the recipe with the recipeid = " + recipeid + " was changed to " + recipename);
        }

        [Test]
        [TestCase("NewRecipe-5", 45, "2022-3-22")]
        [TestCase("Chocolate Cake", 200, "2023-5-12")]
        [TestCase("Vanilla Iced Coffee", 90, "2035-1-1")]
        [TestCase("Pancake", 150, "2024-3-30")]
        [TestCase("Ceasar Salad", 65, "2022-6-15")]
        public void AddRecipe(string recipename, int calorie, DateTime datedrafted)
        {
            DataTable dt = SQLUtility.GetDataTable("select * from recipe where recipeid = 0");
            DataRow r = dt.Rows.Add();
            Assume.That(dt.Rows.Count == 1);
            int cuisineid = SQLUtility.GetFirstColumnFirstRowValue("select cuisineid from cuisine");
            Assume.That(cuisineid > 0, "There are no cuisines in the cuisine table, so can't run the test");
            int userstaffid = SQLUtility.GetFirstColumnFirstRowValue("select userstaffid from userstaff");
            Assume.That(userstaffid > 0, "There are no users in the userstaff table, so can't run the test");
            TestContext.WriteLine("Add a recipe with the recipename, " + recipename);
            
            r["RecipeName"] = recipename;
            r["CuisineId"] = cuisineid;
            r["UserStaffId"] = userstaffid;
            r["Calorie"] = calorie;
            r["DateDrafted"] = datedrafted;
            Recipe.Save(dt);

            int newrecipeid = SQLUtility.GetFirstColumnFirstRowValue("select * from recipe r where r.recipename = " + recipename.ToString());
            Assert.That(newrecipeid > 0, "New recipe withe the recipename = " + recipename + " is not found in the database.");
            TestContext.WriteLine("The recipe with the recipename = " + recipename + "was added to the database.");
        }

        [Test]
        public void DeleteRecipe()
        {
            DataTable dt = SQLUtility.GetDataTable("select top 1 recipeid from recipe");
            int recipeid = 0;
            recipeid = (int)dt.Rows[0]["RecipeId"];
            Assume.That(recipeid > 0, "There are no Recipes in the Database, can't run test");
            TestContext.WriteLine("There is an existing recipe with a recipeid " + recipeid);
            TestContext.WriteLine("Ensure that the application can delete the recipe with recipeid = " + recipeid);

            Recipe.Delete(dt);

            DataTable dtafterdelete = SQLUtility.GetDataTable("select * from recipe where recipeid = " + recipeid);
            Assert.That(dtafterdelete.Rows.Count == 0, "The app didn't delete the recipe with a recipeid = " + recipeid);
            TestContext.WriteLine("The app deleted the recipe with a recipeid = " + recipeid);
        }

        [Test]
        public void LoadRecipe()
        {
            int recipeid = (int)SQLUtility.GetFirstColumnFirstRowValue("select recipeid from recipe");
            Assume.That(recipeid > 0, "There are no Recipes in the Data Base so can't run the test");
            TestContext.WriteLine("There is an existing recipe with a recipeid " + recipeid);
            TestContext.WriteLine("Ensure that the recipe with a recipeid = " + recipeid + " will load.");

            DataTable dt = Recipe.Load(recipeid);
            int loadedrecipeid = (int)dt.Rows[0]["RecipeId"];

            Assert.That(loadedrecipeid == recipeid, "The loaded recipeid " + loadedrecipeid + "doesn't = " + recipeid);
            TestContext.WriteLine("The recipe loaded with a recipeid of " + loadedrecipeid);
        }

        [Test]
        public void GetListOfUserStaff()
        {
            int userstaffcount = (int)SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from UserStaff");
            Assume.That(userstaffcount > 0, "There are no Users in the Data Base so can't run the test");
            TestContext.WriteLine("The number of Users in the Data Base = " + userstaffcount);
            TestContext.WriteLine("Ensure that the number of users returned by the app is " + userstaffcount);

            DataTable dt = Recipe.GetUserStaffList();

            Assert.That(dt.Rows.Count == userstaffcount, "The number of users returned by the Database doesn't = " + userstaffcount + ("num of users in the DB."));
            TestContext.WriteLine("The number of users returned by the Database = " + userstaffcount);
        }

        [Test]
        public void GetListOfCuisines()
        {
            int cuisinecount = (int)SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from Cuisine");
            Assume.That(cuisinecount > 0, "There are no cuisines in the Data Base so can't run the test");
            TestContext.WriteLine("The number of Cuisines in the Data Base = " + cuisinecount);
            TestContext.WriteLine("Ensure that the number of cuisines returned by the app is " + cuisinecount);

            DataTable dt = Recipe.GetCuisineList();

            Assert.That(dt.Rows.Count == cuisinecount, "The number of cuisines returned by the Database doesn't = " + cuisinecount + ("num of cuisines in the DB."));
            TestContext.WriteLine("The number of cuisines returned by the Database = " + cuisinecount);
        }
    }
}
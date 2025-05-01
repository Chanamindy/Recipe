using RecipeSystem;

namespace RecipeTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString("Server=.\\SQLExpress;Database=RecipeWebsiteDB;Trusted_Connection=true");
            //("Server=tcp:cmherszaft.database.windows.net,1433;Initial Catalog=RecipeWebsiteDB;Persist Security Info=False;User ID=Chanacpuadmin;Password=Chanaadmin412;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
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
            string sdatedrafted = "1-2-2022";
            DateTime.TryParse(sdatedrafted, out datedrafted);
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
        public void EditRecipeDateDraftedToInvalidDateDrafted()
        {
            int recipeid = SQLUtility.GetFirstColumnFirstRowValue("select recipeid from recipe");
            Assume.That(recipeid > 0, "No recipes in the database, can't run the test.");
            DataTable dtdatedrafted = SQLUtility.GetDataTable("select datedrafted from recipe where recipeid = " + recipeid);
            DateTime datedrafted = (DateTime)dtdatedrafted.Rows[0]["DateDrafted"];
            TestContext.WriteLine("The datedrafted for the recipe with recipeid = " + recipeid + " is " + datedrafted);
            string newdatedrafted = "1-2-2021";
            TestContext.WriteLine("Change the datedrafted from " + datedrafted + " to " + newdatedrafted + " which is before January 1, 2022");

            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["DateDrafted"] = newdatedrafted;

            Exception ex = Assert.Throws<Exception>(() => Recipe.Save(dt));
            TestContext.WriteLine(ex.Message);
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
        public void EditRecipeNameToInvalidRecipeName()
        {
            int recipeid = SQLUtility.GetFirstColumnFirstRowValue("select recipeid from recipe");
            Assume.That(recipeid > 0, "No recipes in the database, can't run the test.");
            string recipename = GetFirstColumnFirstRowValueAsString("select top 1 recipename from recipe where recipeid <> " + recipeid);
            Assume.That(recipename != "", "There are no other Recipe records in the table, can't run test.");
            string currentrecipename = GetFirstColumnFirstRowValueAsString("select top 1 recipename from recipe where recipeid = " + recipeid);
            TestContext.WriteLine("Change the recipeid " + recipeid + " name from " + currentrecipename + " to " + recipename);
            DataTable dt = Recipe.Load(recipeid);
            dt.Rows[0]["RecipeName"] = recipename;
            Exception ex = Assert.Throws<Exception>(()=> Recipe.Save(dt));
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        [TestCase("NewRecipe-5", "2022-3-22")]
        [TestCase("Chocolate Cake", "2023-5-12")]
        [TestCase("Vanilla Iced Coffee", "2023-1-1")]
        [TestCase("Pancake", "2024-3-30")]
        [TestCase("Ceasar Salad", "2022-6-15")]
        public void AddRecipe(string recipename, DateTime datedrafted)
        {
            DataTable dt = SQLUtility.GetDataTable("select * from recipe where recipeid = 0");
            DataRow r = dt.Rows.Add();
            Assume.That(dt.Rows.Count == 1);
            int cuisineid = SQLUtility.GetFirstColumnFirstRowValue("select cuisineid from cuisine");
            Assume.That(cuisineid > 0, "There are no cuisines in the cuisine table, so can't run the test");
            int userstaffid = SQLUtility.GetFirstColumnFirstRowValue("select userstaffid from userstaff");
            Assume.That(userstaffid > 0, "There are no users in the userstaff table, so can't run the test");
            int calorie = SQLUtility.GetFirstColumnFirstRowValue("select max(calorie) from Recipe");
            calorie = calorie + 10;
            DateTime currentdate = DateTime.Now;

            recipename = recipename + " " + currentdate.ToString();
            TestContext.WriteLine("Add a recipe with the recipename, " + recipename + " and calorie = " + calorie);
            
            r["RecipeName"] = recipename;
            r["CuisineId"] = cuisineid;
            r["UserStaffId"] = userstaffid;
            r["Calorie"] = calorie;
            r["DateDrafted"] = datedrafted;

            SQLUtility.DebugPrintDataTable(dt);
            Recipe.Save(dt);

            int newrecipeid = SQLUtility.GetFirstColumnFirstRowValue("select * from recipe r where r.calorie = " + calorie);
            Assert.That(newrecipeid > 0, "New recipe with the recipename = " + recipename + " and calorie = " + calorie + " is not found in the database.");
            TestContext.WriteLine("The recipe with the recipename = " + recipename + " and calorie = " + calorie + " was added to the database.");
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
        public void DeleteRecipeWithMeal()
        {
            DataTable dt = SQLUtility.GetDataTable("select top 1 r.recipeid from recipe r join mealcourserecipe mcr on r.recipeid = mcr.recipeid where mcr.MealCourseRecipeId is not null and r.RecipeStatus = 'Drafted'");
            int recipeid = (int)dt.Rows[0]["recipeid"];
            Assume.That(recipeid > 0, "There are no Recipes with mealcourserecipe and RecipeStatus = Drafted, can't run test");
            TestContext.WriteLine("Existing recipe with mealcourserecipe with recipeid = " + recipeid);
            TestContext.WriteLine("Ensure that the application can't delete the recipe with recipeid = " + recipeid + " which has mealcourserecipes.");

            Exception ex = Assert.Throws<Exception>(()=> Recipe.Delete(dt));
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void DeleteRecipeWithPublishedRecipeStatus()
        {
            string sql = @"
select top 1 r.RecipeId
from Recipe r
where r.RecipeStatus = 'Published'
";
            DataTable dt = SQLUtility.GetDataTable(sql);
            int recipeid = (int)dt.Rows[0]["recipeid"];
            Assume.That(recipeid > 0, "There are no Recipes with a Published recipe status, can't run test");
            TestContext.WriteLine("Existing recipe with Published recipe status with recipeid = " + recipeid);
            TestContext.WriteLine("Ensure that the application can't delete the recipe with recipeid = " + recipeid + " which has a Published recipe status.");

            Exception ex = Assert.Throws<Exception>(() => Recipe.Delete(dt));
            TestContext.WriteLine(ex.Message);
        }

        [Test]
        public void DeleteRecipeArchivedLessThan30Days()
        {
            string sql = @"
select top 1 r.RecipeId
from Recipe r
where r.RecipeStatus = 'Archived' and datediff(day, r.DateArchived, getdate()) < 30
";
            DataTable dt = SQLUtility.GetDataTable(sql);
            int recipeid = (int)dt.Rows[0]["recipeid"];
            Assume.That(recipeid > 0, "There are no Recipes with Archived for less than 30 days, can't run test");
            TestContext.WriteLine("Existing recipe Archived for less than 30 days with recipeid = " + recipeid);
            TestContext.WriteLine("Ensure that the application can't delete the recipe with recipeid = " + recipeid + " which has been Archived for less than 30 days.");

            Exception ex = Assert.Throws<Exception>(() => Recipe.Delete(dt));
            TestContext.WriteLine(ex.Message);
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

        private string GetFirstColumnFirstRowValueAsString(string sql)
        {
            string s = "";
            DataTable dt = SQLUtility.GetDataTable(sql);
            if (dt.Rows.Count > 0 && dt.Columns.Count > 0)
            {
                if (dt.Rows[0][0] != DBNull.Value)
                {
                    s = dt.Rows[0][0].ToString();
                }
            }
            return s;
        }
    }
}
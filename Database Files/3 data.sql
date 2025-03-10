--AS Fantastic job! 100% 
use RecipeWebsiteDB 
go
delete CookBookRecipe 
delete CookBook 
delete MealCourseRecipe 
delete MealCourse 
delete Course 
delete Meal 
delete RecipeDirection 
delete RecipeIngredient
delete Measurement 
delete Recipe 
delete UserStaff 
delete Ingredient 
delete Cuisine 
go 

insert Cuisine(CuisineType)
select 'American'
union select 'Chinese'
union select 'French'
union select 'English'
union select 'Italian'
union select 'Israeli'

insert Ingredient(IngredientName)
select 'Flour'
union select 'Sugar'
union select 'Water'
union select 'Chicken Cutlets'
union select 'Salt'
union select 'Chocolate Chips'
union select 'Ketchup'
union select 'Mustard'
union select 'Barbecue Sauce'
union select 'Honey'
union select 'Baking Powder'
union select 'Baking Soda'
union select 'Garlic Powder'
union select 'Onion Powder'
union select 'Paprika'
union select 'Black Pepper'
union select 'Maple Syrup'
union select 'Ice Cubes'
union select 'Vanilla Sugar'
union select 'Vanilla Pudding'
union select 'Granny Smith Apples'
union select 'Orange Juice'
union select 'Grape Juice'
union select 'Lemon Juice'
union select 'Golden Delicious Apples'
union select 'Honey Crisp Apples'
union select 'Oil'
union select 'Bread'
union select 'Butter'
union select 'Whipped Cream Cheese'
union select 'Shredded Cheese'
union select 'Vanilla Yogurt'
union select 'Frozen Strawberries'
union select 'Frozen Blueberries'
union select 'Sour Cream Cheese'
union select 'Eggs'
union select 'Garlic'
union select 'Whole Wheat Flour'
union select 'Cumin'
union select 'Vanilla Yogurt'

insert UserStaff(UserFirstName, UserLastName, UserName)
select 'Chaim', 'Klien', 'CC925AA'
union select 'Boruch', 'Katzenstien', 'BB785RT'
union select 'Devora', 'Kimmelman', 'EV750PP'
union select 'Chaya', 'Perstien', 'OO419KX'
union select 'Tzvi', 'Ornstien', 'ST505SS'
union select 'Rivky', 'Friedman', 'PS021WN'
union select 'Hindy', 'Feder', 'BJ452NN'
union select 'Malka', 'Fishman', 'MM452OK'

;
with x as(
    select Recipe = 'Apple Yogurt Smoothie', Cuisine = 'French', Calorie = 65, DateDrafted = '2023-09-24', DatePublished = '2023-11-01', DateArchived = null, UserStaff = 'CC925AA'
    union select 'Chocolate Chip Cookies', 'American', 150, '2022-02-11', '2022-06-06', null, 'OO419KX'
    union select 'Cheese Bread', 'English', 200, '2024-03-16', '2024-05-10', null, 'ST505SS'
    union select 'Butter Muffins', 'American', 110, '2024-06-21', '2024-07-02', null, 'CC925AA'
    union select 'Chinese Chicken', 'Chinese', 160, '2023-10-06', null, '2023-12-26', 'BJ452NN'
    union select 'Bark', 'American', 185, '2023-06-07', null, null, 'MM452OK'
)
insert Recipe(CuisineId, UserStaffId, RecipeName, Calorie, DateDrafted, DatePublished, DateArchived)
select c.CuisineId, us.UserStaffId, x.Recipe, x.Calorie, x.DateDrafted, x.DatePublished, x.DateArchived
from x 
join Cuisine c 
on c.CuisineType = x.Cuisine 
join UserStaff us 
on us.UserName = x.UserStaff

insert Measurement(MeasurementType)
select 'cup'
union select 'oz'
union select 'tsp'
union select 'T'
union select 'quart'
union select 'pinch'
union select 'club'
union select 'cloves'
union select 'stick'

;
with x as(
    select Recipe = 'Chocolate Chip Cookies', Ingredient = 'Sugar', Amount = 1, Measurement = 'cup', IngredientSequence = 1
    union select 'Chocolate Chip Cookies', 'Oil', .5, 'cup', 2
    union select 'Chocolate Chip Cookies', 'Eggs', 3, null, 3
    union select 'Chocolate Chip Cookies', 'Flour', 2, 'cup', 4
    union select 'Chocolate Chip Cookies', 'Vanilla Sugar', 1, 'tsp', 5
    union select 'Chocolate Chip Cookies', 'baking powder', 2, 'tsp', 6
    union select 'Chocolate Chip Cookies', 'baking soda', .5, 'tsp', 7
    union select 'Chocolate Chip Cookies', 'Chocolate Chips', 1, 'cup', 8
    union select 'Apple Yogurt Smoothie', 'granny smith apples', 3, null, 1
    union select 'Apple Yogurt Smoothie', 'vanilla yogurt', 2, 'cup', 2
    union select 'Apple Yogurt Smoothie', 'sugar', 2, 'tsp', 3
    union select 'Apple Yogurt Smoothie', 'orange juice', .5, 'cup', 4
    union select 'Apple Yogurt Smoothie', 'honey', 2, 'tsp', 5
    union select 'Apple Yogurt Smoothie', 'ice cubes', 6, null, 6
    union select 'Cheese Bread', 'bread', 1, 'club', 1
    union select 'Cheese Bread', 'butter', 4, 'oz', 2
    union select 'Cheese Bread', 'shredded cheese', 8, 'oz', 3
    union select 'Cheese Bread', 'garlic', 2, 'cloves', 4
    union select 'Cheese Bread', 'black pepper', .25, 'tsp', 5
    union select 'Cheese Bread', 'salt', 1, 'pinch', 6
    union select 'Butter Muffins', 'butter', 1, 'stick', 1
    union select 'Butter Muffins', 'sugar', 3, 'cup', 2
    union select 'Butter Muffins', 'vanilla pudding', 2, 'tsp', 3
    union select 'Butter Muffins', 'eggs', 4, null, 4
    union select 'Butter Muffins', 'whipped cream cheese', 8, 'oz', 5
    union select 'Butter Muffins', 'sour cream cheese', 8, 'oz', 6
    union select 'Butter Muffins', 'flour', 1, 'cup', 7
    union select 'Butter Muffins', 'baking powder', 2, 'tsp', 8
    union select 'Chinese Chicken', 'Chicken Cutlets', 4, null, 1
    union select 'Chinese Chicken', 'Barbecue Sauce', 2, 'T', 2
    union select 'Chinese Chicken', 'Cumin', .5, 'tsp', 3
)
insert RecipeIngredient(RecipeId, IngredientId, MeasurementId, Amount, IngredientSequence)
select r.RecipeId, i.IngredientId, m.MeasurementId, x.Amount, x.IngredientSequence
from x 
left join Recipe r 
on x.Recipe = r.RecipeName
left join Ingredient i 
on x.Ingredient = i.IngredientName
left join Measurement m 
on x.Measurement = m.MeasurementType

;
with x as(
    select Recipe = 'Chocolate Chip Cookies', Num = 1, Instructions = 'First combine sugar, oil and eggs in a bowl.'
    union select 'Chocolate Chip Cookies', 2, 'Mix well.'
    union select 'Chocolate Chip Cookies', 3, 'Add flour, vanilla sugar, baking powder and baking soda.'
    union select 'Chocolate Chip Cookies', 4, 'Beat for 5 minutes.'
    union select 'Chocolate Chip Cookies', 5, 'Add chocolate chips.'
    union select 'Chocolate Chip Cookies', 6, 'Freeze for 1-2 hours.'
    union select 'Chocolate Chip Cookies', 7, 'Roll into balls and place spread out on a cookie sheet.'
    union select 'Chocolate Chip Cookies', 8, 'Bake on 350 for 10 min.'
    union select 'Apple Yogurt Smoothie', 1, 'Peel the apples and dice.'
    union select 'Apple Yogurt Smoothie', 2, 'Combine all ingredients in bowl except for apples and ice cubes.'
    union select 'Apple Yogurt Smoothie', 3, 'Mix until smooth.'
    union select 'Apple Yogurt Smoothie', 4, 'Add apples and ice cubes.'
    union select 'Apple Yogurt Smoothie', 5, 'Pour into glasses.'
    union select 'Cheese Bread', 1, 'Slit bread every 3/4 inch.'
    union select 'Cheese Bread', 2, 'Combine all ingredients in bowl.'
    union select 'Cheese Bread', 3, 'Fill slits with cheese mixture.'
    union select 'Cheese Bread', 4, 'Wrap bread into a foil and bake for 30 minutes.'
    union select 'Butter Muffins', 1, 'Cream butter with sugars.'
    union select 'Butter Muffins', 2, 'Add eggs and mix well.'
    union select 'Butter Muffins', 3, 'Slowly add rest of ingredients and mix well.'
    union select 'Butter Muffins', 4, 'Fill muffin pans 3/4 full and bake for 30 minutes.'
)
insert RecipeDirection(RecipeId, RecipeDirectionSequence, Instructions)
select r.RecipeId, x.Num, x.Instructions
from x 
join Recipe r 
on x.Recipe = r.RecipeName

;
with x as(
    select Meal = 'Breakfast Bash', MealStatus = 1, DateCreated = '2022-02-03', UserStaffName = 'PS021WN'
    union select 'Lavish Lunch', 1, '2023-02-23', 'EV750PP'
    union select 'Supper Special', 0, '2022-05-19', 'OO419KX'
    union select 'Dinner Two', 1, '2024-02-20', 'ST505SS'
)
insert Meal(UserStaffId, MealName, MealStatus, DateCreated)
select us.UserStaffId, x.Meal, x.MealStatus, x.DateCreated
from x 
join UserStaff us 
on x.UserStaffName = us.UserName 

insert Course(CourseName, CourseSequence)
select 'Appetizer', 1
union select 'Soup', 2
union select 'Main Course', 3
union select 'Dessert', 4

insert MealCourse(MealId, CourseId)
select m.MealId, c.CourseId
from Meal m 
cross join Course c 

;
with x as(
    select Meal = 'Breakfast Bash', Course = 'Main Course', Recipe = 'Cheese Bread', Main = 1
    union select 'Breakfast Bash', 'Main Course', 'Butter Muffins', 0
    union select 'Breakfast Bash', 'Appetizer', 'Apple Yogurt Smoothie', 0
    union select 'Lavish Lunch', 'Main Course', 'Cheese Bread', 1
    union select 'Lavish Lunch', 'Dessert', 'Chocolate Chip Cookies', 0
)
insert MealCourseRecipe(MealCourseId, RecipeId, Main)
select mc.MealCourseId, r.RecipeId, x.Main
from x 
join Meal m 
on x.Meal = m.MealName
join MealCourse mc 
on m.MealId = mc.MealId 
join Course c 
on mc.CourseId = c.CourseId
join Recipe r 
on x.Recipe = r.RecipeName
where m.MealName = x.Meal and c.CourseName = x.Course

;
with x as(
    select CookBook = 'Treats for two', Price = 30.00, CookBookStatus = 1, DateCreated = '2023-04-20', UserStaff = 'BB785RT'
    union select 'Meal Bests', 32.99, 0, '2023-09-12', 'ST505SS'
)
insert CookBook(UserStaffId, CookBookName, CookBookPrice, CookBookStatus, DateCreated)
select us.UserStaffId, x.CookBook, x.Price, x.CookBookStatus, x.DateCreated
from x 
join UserStaff us 
on x.UserStaff = us.UserName

;
with x as(
    select CookBook = 'Treats for two', Recipe = 'Chocolate Chip Cookies', RecipeSequence = 1
    union select 'Treats for two', 'Apple Yogurt Smoothie', 2
    union select 'Treats for two', 'Cheese Bread', 3
    union select 'Treats for two', 'Butter Muffins', 4
    union select 'Meal Bests', 'Apple Yogurt Smoothie', 1
    union select 'Meal Bests', 'Chocolate Chip Cookies', 2
)
insert CookBookRecipe(CookBookId, RecipeId, RecipeSequence)
select cb.CookBookId, r.RecipeId, x.RecipeSequence
from x 
join CookBook cb 
on x.CookBook = cb.CookBookName 
join Recipe r 
on x.Recipe = r.RecipeName
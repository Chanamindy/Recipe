use RecipeWebsiteDB 
go 
delete recipeingredient
delete recipedirection
delete mealcourserecipe
delete cookbookrecipe
delete recipe

;
with x as(
    select Recipe = 'Red Apple Yogurt Smoothie', Cuisine = 'French', Calorie = 65, DateDrafted = '2023-09-24', DatePublished = '2023-11-01', DateArchived = null, UserStaff = 'CC925AA'
    union select 'Chocolate Chip Cookie', 'American', 150, '2022-02-11', '2022-06-06', null, 'OO419KX'
    union select 'Round Cheese Bread', 'English', 200, '2024-03-16', '2024-05-10', null, 'ST505SS'
    union select 'Butter Muffin', 'American', 110, '2024-06-21', '2024-07-02', null, 'CC925AA'
    union select 'Chinese Pepper Chicken', 'Chinese', 160, '2023-10-06', null, '2023-12-26', 'BJ452NN'
    union select 'Nut Bark', 'American', 185, '2023-06-07', null, null, 'MM452OK'
)
insert Recipe(CuisineId, UserStaffId, RecipeName, Calorie, DateDrafted, DatePublished, DateArchived)
select c.CuisineId, us.UserStaffId, x.Recipe, x.Calorie, x.DateDrafted, x.DatePublished, x.DateArchived
from x 
join Cuisine c 
on c.CuisineType = x.Cuisine 
join UserStaff us 
on us.UserName = x.UserStaff
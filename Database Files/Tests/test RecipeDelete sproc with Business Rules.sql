select * from Recipe 
insert Recipe(CuisineId, UserStaffId, RecipeName, Calorie, DateDrafted, DatePublished, DateArchived)
select r.CuisineId, r.UserStaffId, 'Butter New', r.Calorie, '2024-11-02', '2024-12-20', '2025-04-20' 
from Recipe r where r.RecipeName = 'Butter Muffins'

insert Recipe(CuisineId, UserStaffId, RecipeName, Calorie, DateDrafted, DatePublished, DateArchived)
select r.CuisineId, r.UserStaffId, 'Butter milk3', r.Calorie, '2024-11-02', null, null
from Recipe r where r.RecipeName = 'Butter Muffins'

declare @RecipeId int
select @RecipeId = r.RecipeId 
from Recipe r 
where r.RecipeName = 'Butter milk3'

select *
from Recipe r 
where r.RecipeName = 'Butter milk3'

declare @return int, @Message varchar(500)
exec @return = RecipeDelete @RecipeId = @RecipeId, @Message = @Message output

select *
from Recipe r 
where r.RecipeName = 'Butter milk3'

update Recipe 
set DatePublished = null, DateArchived = null
--select *
from Recipe r 
where r.RecipeName = 'Chocolate Chip Cookies'

select top 1 r.recipeid from recipe r join mealcourserecipe mcr on r.recipeid = mcr.recipeid where mcr.MealCourseRecipeId is not null and r.RecipeStatus = 'Drafted'
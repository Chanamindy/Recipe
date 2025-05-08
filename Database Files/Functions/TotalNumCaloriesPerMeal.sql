create or alter function dbo.TotalNumCaloriesPerMeal(@MealId int)
returns int
as 
begin 
   declare @value int = 0 

    select @value = sum(isnull(r.Calorie, 0))
    from Meal m
    left join MealCourse mc  
    on m.MealId = mc.MealId
    left join MealCourseRecipe mcr 
    on mc.MealCourseId = mcr.MealCourseId
    left join Recipe r 
    on mcr.RecipeId = r.RecipeId
    where m.MealId = @MealId
    group by m.MealName

   return @value
end 
go 

select TotalNumCaloriesPerMeal = dbo.TotalNumCaloriesPerMeal(m.MealId), *
from Meal m
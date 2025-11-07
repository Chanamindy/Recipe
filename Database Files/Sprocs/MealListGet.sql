create or alter proc MealListGet(
	@Message varchar(500) = '' output
)
as 
begin
	select m.MealName, UserName = concat(us.UserFirstName, ' ', us.UserLastName), NumCalories = sum(r.Calorie), NumCourses = count(mc.MealCourseId), NumRecipes = count(mcr.RecipeId)
	from Meal m 
	join MealCourse mc 
	on m.MealId = mc.MealId 
	join MealCourseRecipe mcr 
	on mc.MealCourseId = mcr.MealCourseId
	join Recipe r 
	on mcr.RecipeId = r.RecipeId
	join Course c 
	on mc.CourseId = c.CourseId
	join UserStaff us 
	on m.UserStaffId = us.UserStaffId
	group by m.MealName, us.UserFirstName, us.UserLastName
end
go

		
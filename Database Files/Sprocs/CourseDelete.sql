create or alter proc dbo.CourseDelete(
	@CourseId int = 0,
	@Message varchar(500) = ''
)
as 
begin
	delete mcr
	from MealCourseRecipe mcr
	join MealCourse mc
	on mcr.MealCourseId = mc.MealCourseId
	join Course c
	on mc.CourseId = c.CourseId
	where mc.CourseId = @CourseId

	delete mc
	from MealCourse mc 
	join Course c
	on mc.CourseId = c.CourseId
	where mc.CourseId = @CourseId
	
	delete Course where CourseId = @CourseId
end
go
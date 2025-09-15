create or alter proc dbo.UserStaffDelete(
	@UserStaffId int = 0,
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	begin try
		begin tran 

		delete ri 
		from Recipe r 
		join RecipeIngredient ri 
		on r.RecipeId = ri.RecipeId
		where r.UserStaffId = @UserStaffId

		delete rd 
		from Recipe r 
		join RecipeDirection rd 
		on r.RecipeId = rd.RecipeId 
		where r.UserStaffId = @UserStaffId

		delete cbr 
		from Recipe r 
		left join CookbookRecipe cbr 
		on r.RecipeId = cbr.RecipeId
		where r.UserStaffId = @UserStaffId 
		
		delete mcr 
		from MealCourseRecipe mcr 
		join MealCourse mc
		on mcr.MealCourseId = mc.MealCourseId
		join Meal m
		on mc.MealId = m.MealId
		where m.UserStaffId = @UserStaffId

		delete mc 
		from Meal m
		join MealCourse mc 
		on m.MealId = mc.MealId 
		where m.UserStaffId = @UserStaffId

		delete mcr 
		from MealCourseRecipe mcr 
		join Recipe r 
		on mcr.RecipeId = r.RecipeId 
		where r.RecipeId = @UserStaffId

		delete cbr 
		from CookbookRecipe cbr 
		join Recipe r 
		on cbr.RecipeId = r.RecipeId 
		where r.UserStaffId = @UserStaffId

		delete r from Recipe r where r.UserStaffId = @UserStaffId
		delete m from Meal m where m.UserStaffId = @UserStaffId
		delete cb from Cookbook cb where cb.UserStaffId = @UserStaffId
		delete us from UserStaff us where us.UserStaffId = @UserStaffId

		commit
	end try
	begin catch
		rollback;
		throw
	end catch

	finished:
	return @return
end
go
/*
		select *
		from MealCourseRecipe mcr 
		join MealCourse mc
		on mcr.MealCourseId = mc.MealCourseId
		join Meal m
		on mc.MealId = m.MealId
		where m.UserStaffId = 126

		select * 
		from Meal m
		join MealCourse mc 
		on m.MealId = mc.MealId 
		where m.UserStaffId = 118

		select * from UserStaff
		*/
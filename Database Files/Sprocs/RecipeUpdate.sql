create or alter procedure dbo.RecipeUpdate(
	@RecipeId int output,
	@CuisineId int,
	@UserStaffId int,
	@RecipeName varchar (50),
	@Calorie int,
	@DateDrafted datetime,
	@DatePublished datetime,
	@DateArchived datetime
)
as 
begin
	declare @Return int = 0

	select @RecipeId = isnull(@RecipeId, 0), @DateDrafted = isnull(@DateDrafted, getdate())
	
	if @RecipeId = 0
	begin 
		insert Recipe(CuisineId, UserStaffId, RecipeName, Calorie, DateDrafted, DatePublished, DateArchived)
		values(@CuisineId, @UserStaffId, @RecipeName, @Calorie, @DateDrafted, @DatePublished, @DateArchived)

		select @RecipeId = SCOPE_IDENTITY()
	end

	else
	begin 
		update Recipe 
		set 
			CuisineId = @CuisineId, 
			UserStaffId = @UserStaffId, 
			RecipeName = @RecipeName, 
			Calorie = @Calorie, 
			DateDrafted = @DateDrafted, 
			DatePublished = @DatePublished, 
			DateArchived = @DateArchived
		where RecipeId = @RecipeId
	end

	select * from Recipe r
	where r.RecipeId = @RecipeId
end
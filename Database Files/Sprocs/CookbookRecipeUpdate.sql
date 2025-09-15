create or alter proc dbo.CookbookRecipeUpdate(
	@CookbookRecipeId int = 0 output,
	@CookbookId int = 0,
	@RecipeId int = 0,
	@RecipeSequence int = 0
)
as 
begin
	declare @Return int = 0

	select @CookbookRecipeId = isnull(@CookbookRecipeId, 0)

	if @CookbookRecipeId = 0
	begin
		insert CookbookRecipe(CookbookId, RecipeId , RecipeSequence)
		values (@CookbookId, @RecipeId, @RecipeSequence)

		select @CookbookRecipeId = SCOPE_IDENTITY()
	end 

	else
	begin
		update CookbookRecipe
		set
			CookbookId = @CookbookId,
			RecipeId = @RecipeId,
			RecipeSequence = @RecipeSequence
		where CookbookRecipeId = @CookbookRecipeId
	end
end 
go
create or alter proc dbo.CookbookRecipesGet(
	@CookbookId int = 0,
	@Message varchar(500) = '' output
)
as 
begin
	select cbr.CookbookRecipeId, cbr.CookbookId, r.RecipeId, cbr.RecipeSequence
	from CookbookRecipe cbr 
	join Recipe r 
	on cbr.RecipeId = r.RecipeId
	where cbr.CookbookId = @CookbookId
	order by cbr.RecipeSequence
end
go
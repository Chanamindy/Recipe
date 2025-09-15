create or alter proc dbo.RecipeIngredientDelete(
	@RecipeIngredientId int = 0,
	@Message varchar(500) = '' output
)
as 
begin
	delete RecipeIngredient where RecipeIngredientId = @RecipeIngredientId
end
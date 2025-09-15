create or alter proc dbo.RecipeDirectionDelete(
	@RecipeDirectionId int = 0,
	@Message varchar(500) = '' output
)
as 
begin
	delete RecipeDirection where RecipeDirectionId = @RecipeDirectionId
end
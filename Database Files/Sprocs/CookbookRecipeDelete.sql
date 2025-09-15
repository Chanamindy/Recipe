create or alter proc dbo.CookbookRecipeDelete(
	@CookbookRecipeId int = 0,
	@Message varchar(500) = '' output
)
as 
begin
	delete CookbookRecipe
	where CookbookRecipeId = @CookbookRecipeId
end
go
create or alter proc dbo.IngredientDelete(
	@IngredientId int = 0,
	@Message varchar(500) = ''
)
as 
begin
	delete Ingredient where IngredientId = @IngredientId
end
go
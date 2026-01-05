create or alter proc dbo.IngredientDelete(
	@IngredientId int = 0,
	@Message varchar(500) = ''
)
as 
begin
	delete ri
	from RecipeIngredient ri 
	join Ingredient i
	on ri.IngredientId = i.IngredientId
	where ri.IngredientId = @IngredientId
	
	delete Ingredient where IngredientId = @IngredientId
end
go
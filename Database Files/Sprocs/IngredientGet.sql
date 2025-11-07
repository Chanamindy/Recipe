create or alter proc IngredientGet(
	@IngredientId int = 0,
	@All int = 0,
	@Message varchar(500) = '' output
)
as 
begin
	select i.IngredientId, i.IngredientName 
	from Ingredient i
	where i.IngredientId = @IngredientId 
	or @All = 1
end
go
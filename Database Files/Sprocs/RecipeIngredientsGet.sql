create or alter proc RecipeIngredientsGet(
	@RecipeId int = 0,
	@Message varchar(500) = '' output
)
as
begin
	select ri.RecipeIngredientId, ri.RecipeId, ri.Amount, m.MeasurementId, i.IngredientId, ri.IngredientSequence
	from Recipe r 
	join RecipeIngredient ri 
	on r.RecipeId = ri.RecipeId
	join Ingredient i 
	on ri.IngredientId = i.IngredientId
	join Measurement m 
	on ri.MeasurementId = m.MeasurementId
	where r.RecipeId = @RecipeId
	order by ri.IngredientSequence
end
go

--exec RecipeIngredientsGet @RecipeId = 2
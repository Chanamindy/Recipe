create or alter proc dbo.CloneRecipe(
	@RecipeId int = 0,
	@RecipeIdnew int = 0 output,
	@Message varchar(500) = '' output
)
as 
begin
	insert Recipe(CuisineId, UserStaffId, RecipeName, Calorie, DateDrafted, DatePublished, DateArchived)
	select r.CuisineId, r.UserStaffId, concat(r.RecipeName, ' - clone'), r.Calorie, r.DateDrafted, r.DatePublished, r.DateArchived
	from Recipe r 
	where r.RecipeId = @RecipeId

	select @RecipeIdnew = SCOPE_IDENTITY()

	; 
	with x as(
		select r.RecipeName, r.RecipeId 
		from Recipe r 
		where r.RecipeId = @RecipeIdnew
	)
	insert RecipeIngredient(RecipeId, IngredientId, MeasurementId, Amount, IngredientSequence)
	select x.RecipeId, ri.IngredientId, ri.MeasurementId, ri.Amount, ri.IngredientSequence
	from RecipeIngredient ri 
	join Recipe r 
	on ri.RecipeId = r.RecipeId 
	cross join x 
	where r.RecipeId = @RecipeId

	;
	with x as(
		select r.RecipeName, r.RecipeId 
		from Recipe r 
		where r.RecipeId = @RecipeIdnew
	)
	insert RecipeDirection(RecipeId, RecipeDirectionSequence, Instructions)
	select x.RecipeId, rd.RecipeDirectionSequence, rd.Instructions
	from RecipeDirection rd 
	join Recipe r 
	on rd.RecipeId = r.RecipeId 
	cross join x 
	where r.RecipeId = @RecipeId

	select *
	from Recipe r
	where r.RecipeId = @RecipeIdnew
end
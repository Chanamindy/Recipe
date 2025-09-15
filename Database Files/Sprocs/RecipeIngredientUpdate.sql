create or alter proc dbo.RecipeIngredientUpdate(
	@RecipeIngredientId int = 0 output,
	@RecipeId int = 0,
	@IngredientId int = 0,
	@MeasurementId int = 0,
	@Amount decimal(5,2) = 0,
	@IngredientSequence int = 0
)
as
begin
	select @RecipeIngredientId = isnull(@RecipeIngredientId, 0)

	if @RecipeIngredientId = 0
	begin
		insert RecipeIngredient(RecipeId, IngredientId, MeasurementId, Amount, IngredientSequence)
		values(@RecipeId, @IngredientId, @MeasurementId, @Amount, @IngredientSequence)

		select @RecipeIngredientId = SCOPE_IDENTITY()
	end
	else
	begin
		update RecipeIngredient
		set
			RecipeId = @RecipeId,
			IngredientId = @IngredientId,
			MeasurementId = @MeasurementId,
			Amount = @Amount,
			IngredientSequence = @IngredientSequence
		where RecipeIngredientId = @RecipeIngredientId
	end
end
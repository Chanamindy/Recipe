create or alter proc dbo.RecipeDirectionUpdate(
	@RecipeDirectionId int = 0 output,
	@RecipeId int = 0,
	@RecipeDirectionSequence int = 0,
	@Instructions varchar(300) = ''
)
as 
begin
	select @RecipeDirectionId = isnull(@RecipeDirectionId, 0)

	if @RecipeDirectionId = 0
	begin
		insert RecipeDirection(RecipeId, RecipeDirectionSequence, Instructions)
		values(@RecipeId, @RecipeDirectionSequence, @Instructions)

		select @RecipeDirectionId = SCOPE_IDENTITY()
	end
	else
	begin
		update RecipeDirection
		set
			RecipeId = @RecipeId,
			RecipeDirectionSequence = @RecipeDirectionSequence,
			Instructions = @Instructions
		where RecipeDirectionId = @RecipeDirectionId
	end
end
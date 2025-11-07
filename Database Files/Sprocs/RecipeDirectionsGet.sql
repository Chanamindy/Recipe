create or alter proc RecipeDirectionsGet(
	@RecipeId int = 0,
	@Message varchar(500) = '' output
)
as
begin
	select rd.RecipeDirectionId, rd.RecipeId, rd.Instructions, rd.RecipeDirectionSequence
	from Recipe r 
	join RecipeDirection rd 
	on r.RecipeId = rd.RecipeId
	where r.RecipeId = @RecipeId
	order by rd.RecipeDirectionSequence
end
create or alter proc dbo.ChangeRecipeStatus(
	@RecipeId int = 0,
	@NewRecipeStatus varchar(9) = '',
	@Message varchar(500) = '' output
)
as 
begin
	select @RecipeId = isnull(@RecipeId, 0)

	update r
	set 
		r.DateDrafted = 
		case @NewRecipeStatus
		when 'Draft' then datepart(month, getdate())
		else r.DateDrafted 
		end,
		r.DatePublished = 
		case @NewRecipeStatus
		when 'Publish' then getdate()
		else r.DatePublished 
		end,
		r.DateArchived = 
		case @NewRecipeStatus
		when 'Archive' then getdate()
		else r.DateArchived
		end
	from Recipe r
	where r.RecipeId = @RecipeId
end
go
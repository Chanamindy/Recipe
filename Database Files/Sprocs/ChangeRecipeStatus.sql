create or alter proc dbo.ChangeRecipeStatus(
	@RecipeId int = 0,
	@RecipeStatus varchar(9) = '',
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
		when 'Draft' then convert(varchar, getdate(), 101)
		else r.DateDrafted 
		end,
		r.DatePublished = 
		case 
		when @NewRecipeStatus = 'Publish' then convert(varchar, getdate(), 101)
		when @RecipeStatus in ('Published', 'Archived') and @NewRecipeStatus = 'Draft' then null
		else r.DatePublished 
		end,
		r.DateArchived = 
		case 
		when @NewRecipeStatus = 'Archive' then convert(varchar, getdate(), 101)
		when @RecipeStatus = 'Archived' and @NewRecipeStatus in ('Publish', 'Draft') then null
		else r.DateArchived
		end
	from Recipe r
	where r.RecipeId = @RecipeId
end
go
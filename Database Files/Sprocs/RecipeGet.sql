use RecipeWebsiteDB
go

create or alter procedure dbo.RecipeGet(@RecipeId int = 0, @All bit = 0, @RecipeName varchar(50) = '', @IncludeBlank bit = 0)
as
begin
	select r.RecipeId, r.CuisineId, r.UserStaffId, r.RecipeName, r.Calorie, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipePictureCode 
	from Recipe r
	where r.RecipeId = @RecipeId
	or @All = 1
	or (@RecipeName <> '' and r.RecipeName like '%' + @RecipeName + '%')
	union select 0, 0, 0, ' ', 0, ' ', ' ', ' ', ' ', ' '
	from Recipe 
	where @IncludeBlank = 1
	order by r.RecipeName
end
go
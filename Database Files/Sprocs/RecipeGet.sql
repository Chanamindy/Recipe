use RecipeWebsiteDB
go

create or alter procedure dbo.RecipeGet(@RecipeId int = 0, @All bit = 0, @RecipeName varchar(50) = '')
as
begin
	select r.RecipeId, r.CuisineId, r.RecipeName, r.Calorie, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipePictureCode 
	from Recipe r
	where r.RecipeId = @RecipeId
	or @All = 1
	or (@RecipeName <> '' and r.RecipeName like '%' + @RecipeName + '%')
	order by r.RecipeName
end
go

/*
execute dbo.RecipeGet --Return no results

execute dbo.RecipeGet @RecipeName = null -- Return no results

declare @RecipeId int
select top 1 @RecipeId = RecipeId from Recipe
execute dbo.RecipeGet @RecipeId = @RecipeId

execute dbo.RecipeGet @All = 1

execute dbo.RecipeGet @RecipeName = 'a'
*/
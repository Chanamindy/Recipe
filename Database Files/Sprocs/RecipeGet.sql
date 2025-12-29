create or alter procedure dbo.RecipeGet(@RecipeId int = 0, @All bit = 0, @RecipeName varchar(50) = '', @IncludeBlank bit = 0, @Summary bit = 0)
as
begin
	;
	with x as(
		select NumIngredients = count(ri.RecipeIngredientId), ri.RecipeId
		from RecipeIngredient ri 
		group by ri.RecipeId
	)
	select r.RecipeId, r.CuisineId, r.UserStaffId, RecipeName = case when r.RecipeStatus = 'Archived' and @Summary = 1 then concat('<span style="color:gray">',r.RecipeName,'</span>') else r.RecipeName end, r.Calorie, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipePictureCode, UserName = concat(us.UserFirstName, ' ', us.UserLastName), NumIngredients = isnull(x.NumIngredients, 0)
	from Recipe r
	left join x
	on x.RecipeId = r.RecipeId
	left join UserStaff us 
	on r.UserStaffId = us.UserStaffId
	left join RecipeIngredient ri 
	on r.RecipeId = ri.RecipeId
	where r.RecipeId = @RecipeId
	or @All = 1
	or (@RecipeName <> '' and r.RecipeName like '%' + @RecipeName + '%')
	union select 0, 0, 0, ' ', 0, ' ', ' ', ' ', ' ', ' ', ' ', 0
	from Recipe 
	where @IncludeBlank = 1
	order by r.RecipeStatus desc, RecipeName
end
go
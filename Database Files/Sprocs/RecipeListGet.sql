create or alter proc dbo.RecipeListGet(
	@Message varchar(500) = '' output
)
as
begin
	;
	with x as(
		select NumIngredients = max(ri.IngredientSequence), ri.RecipeId
		from RecipeIngredient ri 
		group by ri.RecipeId
	)
	select distinct r.RecipeId, RecipeName = case when r.RecipeStatus = 'Archived' then concat('<span style="color:gray">',r.RecipeName,'</span>') else r.RecipeName end, Status = r.RecipeStatus, UserName = concat(us.UserFirstName, ' ', us.UserLastName), Calories = r.Calorie, x.NumIngredients
	from Recipe r  
	left join x
	on x.RecipeId = r.RecipeId
	left join UserStaff us 
	on r.UserStaffId = us.UserStaffId
	left join RecipeIngredient ri 
	on r.RecipeId = ri.RecipeId
	order by r.RecipeStatus desc  
end
go

exec RecipeListGet
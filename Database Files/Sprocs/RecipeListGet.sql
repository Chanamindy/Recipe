create or alter proc dbo.RecipeListSummaryGet(
	@Message varchar(500) = '' output
)
as
begin
	;
	with x as(
		select NumIngredients = count(ri.RecipeIngredientId), ri.RecipeId
		from RecipeIngredient ri 
		group by ri.RecipeId
	)
	select distinct r.RecipeId, RecipeName = case when r.RecipeStatus = 'Archived' then concat('<span style="color:gray">',r.RecipeName,'</span>') else r.RecipeName end, Status = r.RecipeStatus, UserName = concat(us.UserFirstName, ' ', us.UserLastName), Calories = r.Calorie, NumIngredients = isnull(x.NumIngredients, 0)
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

exec RecipeListSummaryGet

select * from RecipeIngredient ri
join Recipe r 
on ri.RecipeId = r.RecipeId
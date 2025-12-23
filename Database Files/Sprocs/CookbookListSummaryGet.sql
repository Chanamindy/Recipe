--AS Try to combine with CookbookListGet
create or alter proc dbo.CookbookListSummaryGet(
	@CookbookId int = 0,
	@All bit = 0,
	@Message varchar(500) = '' output
)
as 
begin
	select cb.CookbookId, us.UserStaffId, cb.CookbookName, Author = concat(us.UserFirstName, ' ', us.UserLastName), NumRecipes = count(cbr.RecipeId), cb.CookbookPrice
	from Cookbook cb 
	join UserStaff us 
	on cb.UserStaffId = us.UserStaffId 
	left join CookbookRecipe cbr 
	on cb.CookbookId = cbr.CookbookId 
	left join Recipe r 
	on cbr.RecipeId = r.RecipeId
	where cb.CookbookId = @CookbookId
	or @All = 1
	group by cb.CookbookId, cb.CookbookName, cb.CookbookPrice, us.UserStaffId, us.UserFirstName, us.UserLastName
	order by cb.CookbookName
end 
go
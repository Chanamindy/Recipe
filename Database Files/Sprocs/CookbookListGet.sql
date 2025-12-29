create or alter proc dbo.CookbookListGet(
	@CookbookId int = 0,
	@All bit = 0,
	@Message varchar(500) = '' output
)
as 
begin 
	select cb.CookbookId, us.UserStaffId, cb.CookbookName, cb.CookbookPrice, Author = concat(us.UserFirstName, ' ', us.UserLastName), NumRecipes = count(cbr.RecipeId), cb.CookbookStatus, cb.DateCreated, cb.CookbookPictureCode
	from Cookbook cb 
	join UserStaff us 
	on cb.UserStaffId = us.UserStaffId 
	left join CookbookRecipe cbr 
	on cb.CookbookId = cbr.CookbookId 
	left join Recipe r 
	on cbr.RecipeId = r.RecipeId
	where @All = 1 
	or cb.CookbookId = @CookbookId
	group by cb.CookbookId, cb.CookbookName, cb.CookbookPrice, cb.CookbookStatus, cb.DateCreated, cb.CookbookPictureCode, us.UserStaffId, us.UserFirstName, us.UserLastName
	order by cb.CookbookName
end 
go
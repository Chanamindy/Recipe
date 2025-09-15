create or alter proc dbo.AutoCreateCookbook(
	@UserStaffId int = 0,
	@CookbookId int = 0 output,
	@Message varchar(500) = '' output
)
as 
begin
	;
	with x as(
		select us.UserStaffId, CookBookPrice = (count(r.RecipeId))*1.33
		from UserStaff us 
		join Recipe r 
		on us.UserStaffId = r.UserStaffId
		group by us.UserStaffId
	)
	insert CookBook(UserStaffId, CookBookName, CookBookPrice, CookBookStatus, DateCreated)
	select us.UserStaffId, CookBookName = concat('Recipes by ', us.UserFirstName, ' ', us.UserLastName), x.CookBookPrice, CookBookStatus = 1, DateCreated = getdate()
	from x 
	join UserStaff us 
	on x.UserStaffId = us.UserStaffId
	where us.UserStaffId = @UserStaffId

	select @CookbookId = SCOPE_IDENTITY()

	insert CookBookRecipe(CookBookId, RecipeId, RecipeSequence)
	select cb.CookBookId, r.RecipeId, RecipeSequence = ROW_NUMBER() over (order by r.RecipeId)
	from Recipe r 
	join UserStaff us 
	on r.UserStaffId = us.UserStaffId
	join CookBook cb 
	on us.UserStaffId = cb.UserStaffId
	where cb.UserStaffId = @UserStaffId
	and cb.CookbookId = @CookbookId

	select * from Cookbook
	where CookbookId = @CookbookId
end
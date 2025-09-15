create or alter proc dbo.CookbookUpdate(
	@CookbookId int output,
	@UserStaffId int = 0,
	@CookbookName varchar(30) = '',
	@CookbookPrice decimal(5,2) = 0,
	@CookbookStatus bit = 0,
	@DateCreated date = ''
)
as 
begin 
	declare @Return int = 0

	select @CookbookId = isnull(@CookbookId, 0)

	if @CookbookId = 0
	begin 
		insert Cookbook(UserStaffId, CookbookName, CookbookPrice, CookbookStatus, DateCreated)
		values (@UserStaffId, @CookbookName, @CookbookPrice, @CookbookStatus, @DateCreated)

		select @CookbookId = SCOPE_IDENTITY()
	end

	else
	begin 
		update Cookbook
		set 
			UserStaffId = @UserStaffId,
			CookbookName = @CookbookName,
			CookbookPrice = @CookbookPrice,
			CookbookStatus = @CookbookStatus,
			DateCreated = @DateCreated
		where CookbookId = @CookbookId
	end
end

select * from Cookbook
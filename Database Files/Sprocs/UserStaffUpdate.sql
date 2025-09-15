create or alter proc dbo.UserUpdate(
	@UserStaffId int = 0 output,
	@UserFirstName varchar(30) = '',
	@UserLastName varchar(30) = '',
	@UserName varchar(50) = '',
	@Message varchar(500) = ''
)
as 
begin
	select @UserStaffId = isnull(@UserStaffId, 0)

	if @UserStaffId = 0
	begin
		insert UserStaff(UserFirstName, UserLastName, UserName)
		values(@UserFirstName, @UserLastName, @UserName)

		select @UserStaffId = SCOPE_IDENTITY()
	end
	else
	begin
		update UserStaff
		set
			UserFirstName = @UserFirstName, 
			UserLastName = @UserLastName,
			UserName = @UserName
		where UserStaffId = @UserStaffId
	end
end
create or alter procedure dbo.UserNameGet(@UserStaffId int = 0, @All bit = 0, @UserStaff varchar(30) = '', @IncludeBlank bit = 0)
as
begin
	select us.UserStaffId, UserName = concat(us.UserFirstName, ' ', us.UserLastName), us.UserFirstName, us.UserLastName, us.UserName
	from UserStaff us
	where us.UserStaffId = @UserStaffId
	or @All = 1
	or (@UserStaff <> '' and us.UserLastName like '%' + @UserStaff + '%')
	union select 0, ' ', ' ', ' ', ' '
	where @IncludeBlank = 1
	order by us.UserStaffId
end
go
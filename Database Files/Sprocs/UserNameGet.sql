
use RecipeWebsiteDB	
go

create or alter procedure dbo.UserNameGet(@UserStaffId int = 0, @All bit = 0, @UserName varchar(30) = '')
as
begin
	select us.UserStaffId, UserName = concat(us.UserFirstName, ' ', us.UserLastName), us.UserFirstName, us.UserLastName 
	from UserStaff us
	where us.UserStaffId = @UserStaffId
	or @All = 1
	or (@UserName <> '' and us.UserLastName like '%' + @UserName + '%')
	order by us.UserLastName
end
go


/*
execute dbo.UserNameGet --return no results

execute dbo.UserNameGet @UserName = null --return no results

declare @UserStaffId int
select top 1 @UserStaffId = us.UserStaffId from UserStaff us
execute dbo.UserNameGet @UserStaffId = @UserStaffId

execute dbo.UserNameGet @All = 1

execute dbo.UserNameGet @UserName = 'a'
*/
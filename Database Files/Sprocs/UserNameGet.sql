use RecipeWebsiteDB	
go

create or alter procedure dbo.UserNameGet(@UserStaffId int = 0, @All bit = 0, @UserLastName varchar(30) = '')
as
begin
	select us.UserStaffId, us.UserFirstName, us.UserLastName 
	from UserStaff us
	where us.UserStaffId = @UserStaffId
	or @All = 1
	or (@UserLastName <> '' and us.UserLastName like '%' + @UserLastName + '%')
	order by us.UserLastName
end
go

/*
execute dbo.UserNameGet --return no results

execute dbo.UserNameGet @UserLastName = null --return no results

declare @UserStaffId int
select top 1 @UserStaffId = us.UserStaffId from UserStaff us
execute dbo.UserNameGet @UserStaffId = @UserStaffId

execute dbo.UserNameGet @All = 1

execute dbo.UserNameGet @UserLastName = 'a'
*/
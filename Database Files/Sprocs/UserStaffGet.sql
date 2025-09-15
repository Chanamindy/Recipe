use RecipeWebsiteDB	
go

create or alter procedure dbo.UserStaffGet(@UserStaffId int = 0, @All bit = 0, @UserStaff varchar(30) = '', @IncludeBlank bit = 0)
as
begin
	select us.UserStaffId, UserStaff = concat(us.UserFirstName, ' ', us.UserLastName), us.UserFirstName, us.UserLastName, us.UserName
	from UserStaff us
	where us.UserStaffId = @UserStaffId
	or @All = 1
	or (@UserStaff <> '' and us.UserLastName like '%' + @UserStaff + '%')
	union select 0, ' ', ' ', ' ', ' '
	where @IncludeBlank = 1
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
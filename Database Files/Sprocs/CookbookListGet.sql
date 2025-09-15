create or alter proc dbo.CookbookListGet(
	@CookbookId int = 0,
	@All bit = 0,
	@Message varchar(500) = '' output
)
as 
begin 
	select *
	from Cookbook cb
	where @All = 1
	or cb.CookbookId = @CookbookId
end 
go

--exec CookbookListGet @CookbookId = 1
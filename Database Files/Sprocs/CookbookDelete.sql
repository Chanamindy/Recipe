create or alter proc dbo.CookbookDelete(
	@CookbookId int = 0,
	@Message varchar(500) = '' output
)
as 
begin
	declare @Return int = 0

	begin try
		begin tran
		delete cbr from CookbookRecipe cbr where cbr.CookbookId = @CookbookId
		delete cb from Cookbook cb where CookbookId = @CookbookId
		commit 
	end try
	begin catch 
		rollback; 
        throw 
	end catch

	finished:
	return @return
end
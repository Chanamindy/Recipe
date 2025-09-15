create or alter proc dbo.CuisineDelete(
	@CuisineId int = 0,
	@Message varchar(500) = '' output
)
as
begin
	delete Cuisine where CuisineId = @CuisineId
end
go 


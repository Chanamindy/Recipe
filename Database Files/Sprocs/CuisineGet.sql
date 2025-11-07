use RecipeWebsiteDB
go 

create or alter procedure dbo.CuisineGet(@CuisineId int = 0, @All bit = 0, @CuisineType varchar(35) = '', @IncludeBlank bit = 0)
as
begin
	select @CuisineType = NullIf(@CuisineType, '')
	select c.CuisineId, c.CuisineType
	from Cuisine c
	where c.CuisineId = @CuisineId
	or @All = 1
	or c.CuisineType like '%' + @CuisineType + '%'
	union select 0, ' '
	where @IncludeBlank = 1
	order by c.CuisineType
end
go
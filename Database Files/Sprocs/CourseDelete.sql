create or alter proc dbo.CourseDelete(
	@CourseId int = 0,
	@Message varchar(500) = ''
)
as 
begin
	delete Course where CourseId = @CourseId
end
go
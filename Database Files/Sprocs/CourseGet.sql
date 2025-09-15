create or alter proc CourseGet(
	@CourseId int = 0,
	@All int = 0,
	@Message varchar(500) = '' output
)
as 
begin
	select c.CourseId, c.CourseName, c.CourseSequence
	from Course c
	where c.CourseId = @CourseId 
	or @All = 1
	order by c.CourseSequence
end
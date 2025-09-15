create or alter proc dbo.CourseUpdate(
	@CourseId int = 0 output,
	@CourseName varchar(30) = '',
	@CourseSequence int = 0,
	@Message varchar(500) = '' output
)
as 
begin
	select @CourseId = isnull(@CourseId, 0)

	if @CourseId = 0
	begin
		insert Course(CourseName, CourseSequence)
		values(@CourseName, @CourseSequence)

		select @CourseId = SCOPE_IDENTITY()
	end
	else
	begin
		update Course 
		set
			CourseName = @CourseName,
			CourseSequence = @CourseSequence
		where CourseId = @CourseId
	end
end
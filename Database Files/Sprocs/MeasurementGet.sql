create or alter proc MeasurementGet(
	@MeasurementId int = 0,
	@All int = 0,
	@Message varchar(500) = '' output
)
as 
begin
	select m.MeasurementId, m.MeasurementType
	from Measurement m
	where m.MeasurementId = @MeasurementId 
	or @All = 1
end
go
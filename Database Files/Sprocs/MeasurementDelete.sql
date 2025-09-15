create or alter proc dbo.MeasurementDelete(
	@MeasurementId int = 0,
	@Message varchar(500) = ''
)
as
begin
	delete Measurement where MeasurementId = @MeasurementId
end
go
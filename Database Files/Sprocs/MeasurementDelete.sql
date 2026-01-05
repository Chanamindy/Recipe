create or alter proc dbo.MeasurementDelete(
	@MeasurementId int = 0,
	@Message varchar(500) = ''
)
as
begin
	delete ri
	from RecipeIngredient ri
	join Measurement m 
	on ri.MeasurementId = m.MeasurementId
	where ri.MeasurementId = @MeasurementId

	delete Measurement where MeasurementId = @MeasurementId
end
go
create or alter proc dbo.MeasurementUpdate(
	@MeasurementId int = 0 output,
	@MeasurementType varchar(25) = '',
	@Message varchar(500) = '' output
)
as 
begin
	select @MeasurementId = isnull(@MeasurementId, 0)

	if @MeasurementId = 0
	begin
		insert Measurement(MeasurementType)
		values(@MeasurementType)

		select @MeasurementId = SCOPE_IDENTITY()
	end
	else
	begin
		update Measurement
		set
			MeasurementType = @MeasurementType
		where MeasurementId = @MeasurementId
	end
end


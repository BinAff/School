CREATE PROCEDURE Billing.FineTypeUpdateStatus
(
	@Id BIGINT,
	@IsActive BIT
)
AS
BEGIN
	
	UPDATE Billing.FineType
	SET	
		IsActive = @IsActive
	WHERE Id = @Id

END
CREATE PROCEDURE Billing.FeeUpdateStatus
(
	@Id BIGINT,
	@IsActive BIT
)
AS
BEGIN
	
	UPDATE Billing.Fee
	SET	
		IsActive = @IsActive
	WHERE Id = @Id

END
CREATE PROCEDURE Billing.FeeGroupUpdateStatus
(
	@Id BIGINT,
	@IsActive BIT
)
AS
BEGIN
	
	UPDATE Billing.FeeGroup
	SET	
		IsActive = @IsActive
	WHERE Id = @Id

END
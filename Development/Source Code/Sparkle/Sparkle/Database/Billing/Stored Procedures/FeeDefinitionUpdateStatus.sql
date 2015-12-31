CREATE PROCEDURE Billing.FeeDefinitionUpdateStatus
(
	@Id BIGINT,
	@IsActive BIT
)
AS
BEGIN
	
	UPDATE Billing.FeeDefinition
	SET	
		IsActive = @IsActive
	WHERE Id = @Id

END
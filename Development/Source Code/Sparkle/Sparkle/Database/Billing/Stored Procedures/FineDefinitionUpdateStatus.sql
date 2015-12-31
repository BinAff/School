CREATE PROCEDURE [Billing].[FineDefinitionUpdateStatus]
(
	@Id BIGINT,
	@IsActive BIT
)
AS
BEGIN
	
	UPDATE Billing.FineDefinition
	SET	
		IsActive = @IsActive
	WHERE Id = @Id

END
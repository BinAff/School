CREATE PROCEDURE [Billing].[FineDefinitionUpdate]
(
	@Id BIGINT,
	@Name VARCHAR(50),
	@IsPercentage BIT,
	@FineTypeId BIGINT,
	@AccountId BIGINT
)
AS
BEGIN
	
	UPDATE Billing.FineDefinition
	SET	
		Name = @Name,
		IsPercentage = @IsPercentage,
		FineTypeId = @FineTypeId,
		AccountId = @AccountId
	WHERE Id = @Id
	
END
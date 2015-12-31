CREATE PROCEDURE Billing.FeeDefinitionUpdate
(
	@Id BIGINT,
	@Name VARCHAR(50),
	@FeeGroupId BIGINT,
	@FineDefinitionId BIGINT,
	@AccountId BIGINT
)
AS
BEGIN
	
	UPDATE Billing.FeeDefinition
	SET	
		Name = @Name,
		FeeGroupId = @FeeGroupId,
		FineDefinitionId = @FineDefinitionId,
		AccountId = @AccountId
	WHERE Id = @Id
	
END
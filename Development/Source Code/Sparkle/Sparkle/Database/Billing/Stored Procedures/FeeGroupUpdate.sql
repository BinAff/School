CREATE PROCEDURE Billing.FeeGroupUpdate
(
	@Id BIGINT,
	@Name VARCHAR(50),
	@FrequencyId BIGINT
)
AS
BEGIN
	
	UPDATE Billing.FeeGroup
	SET	
		Name = @Name,
		FrequencyId = @FrequencyId
	WHERE Id = @Id
	
END
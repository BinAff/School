CREATE PROCEDURE Billing.FeeDefinitionInsert
(  
	@Id BIGINT,
	@Name VARCHAR(50),
	@FeeGroupId BIGINT,
	@FineDefinitionId BIGINT,
	@AccountId BIGINT
)
AS
BEGIN	
	
	INSERT INTO Billing.FeeDefinition(Name, FeeGroupId, FineDefinitionId, AccountId, IsActive)
	VALUES(@Name, @FeeGroupId, @FineDefinitionId, @AccountId, 'True')
   
	SET @Id = @@IDENTITY
	
END
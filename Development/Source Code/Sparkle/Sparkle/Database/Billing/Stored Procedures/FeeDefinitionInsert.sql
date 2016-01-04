CREATE PROCEDURE [Billing].[FeeDefinitionInsert]
(  
	@Name VARCHAR(50),
	@FeeGroupId BIGINT,
	@FineDefinitionId BIGINT,
	@AccountId BIGINT,
	@Id BIGINT OUTPUT
)
AS
BEGIN	
	
	INSERT INTO Billing.FeeDefinition(Name, FeeGroupId, FineDefinitionId, AccountId, IsActive)
	VALUES(@Name, @FeeGroupId, @FineDefinitionId, @AccountId, 'True')
   
	SET @Id = @@IDENTITY
	
END
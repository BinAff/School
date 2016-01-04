CREATE PROCEDURE [Billing].[FineDefinitionInsert]
(  
	@Name VARCHAR(50),
	@IsPercentage BIT,
	@FineTypeId BIGINT,
	@AccountId BIGINT,
	@Id BIGINT OUTPUT
)
AS
BEGIN	
	
	INSERT INTO Billing.FineDefinition(Name, IsPercentage, FineTypeId, AccountId, IsActive)
	VALUES(@Name, @IsPercentage, @FineTypeId, @AccountId, 'True')
   
	SET @Id = @@IDENTITY
	
END
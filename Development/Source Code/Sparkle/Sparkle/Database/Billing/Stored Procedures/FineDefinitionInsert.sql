CREATE PROCEDURE [Billing].[FineDefinitionInsert]
(  
	@Id BIGINT,
	@Name VARCHAR(50),
	@IsPercentage BIT,
	@FineTypeId BIGINT,
	@AccountId BIGINT
)
AS
BEGIN	
	
	INSERT INTO Billing.FineDefinition(Name, IsPercentage, FineTypeId, AccountId, IsActive)
	VALUES(@Name, @IsPercentage, @FineTypeId, @AccountId, 'True')
   
	SET @Id = @@IDENTITY
	
END
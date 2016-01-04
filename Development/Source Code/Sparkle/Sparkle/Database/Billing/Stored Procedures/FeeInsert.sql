CREATE PROCEDURE [Billing].[FeeInsert]
(  
	@FeeDefinitionId BIGINT,
	@StandardId BIGINT,
	@CategoryId BIGINT,
	@Amount NUMERIC(10,2),
	@AccountYearId BIGINT,
	@Id BIGINT OUTPUT
)
AS
BEGIN	
	
	INSERT INTO Billing.Fee(FeeDefinitionId, StandardId, CategoryId, Amount, AccountYearId, IsActive)
	VALUES(@FeeDefinitionId, @StandardId, @CategoryId, @Amount, @AccountYearId, 'True')
   
	SET @Id = @@IDENTITY
	
END
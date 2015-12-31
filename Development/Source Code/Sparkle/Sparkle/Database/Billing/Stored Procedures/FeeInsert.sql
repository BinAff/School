CREATE PROCEDURE Billing.FeeInsert
(  
	@Id BIGINT,
	@FeeDefinitionId BIGINT,
	@StandardId BIGINT,
	@CategoryId BIGINT,
	@Amount NUMERIC(10,2),
	@AccountYearId BIGINT
)
AS
BEGIN	
	
	INSERT INTO Billing.Fee(FeeDefinitionId, StandardId, CategoryId, Amount, AccountYearId, IsActive)
	VALUES(@FeeDefinitionId, @StandardId, @CategoryId, @Amount, @AccountYearId, 'True')
   
	SET @Id = @@IDENTITY
	
END
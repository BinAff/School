CREATE PROCEDURE [Billing].[FineInsert]
(  
	@FineDefinitionId BIGINT,
	@StandardId BIGINT = NULL,
	@Amount BIGINT,
	@AccountingYearId BIGINT,
	@Id  BIGINT OUTPUT
)
AS
BEGIN	
	
	INSERT INTO Billing.Fine(FineDefinitionId,StandardId,Amount,AccountingYearId,IsActive)
	VALUES(@FineDefinitionId,@StandardId,@Amount,@AccountingYearId,1)
   
	SET @Id = @@IDENTITY

END
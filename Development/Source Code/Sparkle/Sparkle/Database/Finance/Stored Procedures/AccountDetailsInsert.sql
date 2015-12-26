CREATE PROCEDURE [Finance].[AccountDetailsInsert]
(  
	@AccountingYearId Numeric(10,0),
	@AccountId Numeric(10,0),
	@BillNumber Numeric(10,0) = null,
	@Id  Numeric(10,0) OUTPUT
)
AS
BEGIN	
	
	INSERT INTO Finance.AccountDetails(AccountingYearId,AccountId,BillNumber)
	VALUES(@AccountingYearId,@AccountId,@BillNumber)
   
	SET @Id = @@IDENTITY

END
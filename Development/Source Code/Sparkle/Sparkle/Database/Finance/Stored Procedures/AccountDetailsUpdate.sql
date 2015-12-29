
CREATE PROCEDURE [Finance].[AccountDetailsUpdate]
(
	@Id Numeric(10,0),
	@AccountingYearId Numeric(10,0),	
	@AccountId Numeric(10,0),
	@BillNumber Numeric(10,0)
)
AS

BEGIN
	
	UPDATE Finance.AccountDetails
	SET	
		AccountingYearId = @AccountingYearId,
		AccountId = @AccountId
		WHERE Id = @Id
   END
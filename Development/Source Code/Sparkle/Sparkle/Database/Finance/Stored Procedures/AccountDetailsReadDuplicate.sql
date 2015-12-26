CREATE PROCEDURE [Finance].[AccountDetailsReadDuplicate]
(
	@AccountingYearId Numeric(10,0),
	@AccountId Numeric(10,0)
)
AS
BEGIN

	SELECT Id
	FROM Finance.AccountDetails WITH (NOLOCK)
	WHERE AccountingYearId = @AccountingYearId 
	and AccountId = @AccountId 
				
END
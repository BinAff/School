CREATE PROCEDURE [Finance].[AccountDetailsReadAll]
AS
BEGIN
	
	SELECT Id,AccountingYearId,AccountId,BillNumber
	FROM Finance.AccountDetails WITH (NOLOCK)
   
END
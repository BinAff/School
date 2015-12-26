
CREATE PROCEDURE [Finance].[AccountDetailsRead]
(
   @Id Numeric(10,0)
)
AS
BEGIN
	
   SELECT Id,AccountingYearId,AccountId,BillNumber
   FROM Finance.AccountDetails WITH (NOLOCK)
   WHERE Id = @Id
   
END
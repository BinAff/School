CREATE PROCEDURE [Finance].[AccountingYearRead]
(
   @Id Numeric(10,0)
)
AS
BEGIN
	
   SELECT Id, Name,CurrentFlag
   FROM Finance.AccountingYear WITH (NOLOCK)
   WHERE Id = @Id
   
END
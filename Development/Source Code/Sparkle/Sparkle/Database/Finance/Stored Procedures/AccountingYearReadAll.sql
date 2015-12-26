
CREATE PROCEDURE [Finance].[AccountingYearReadAll]
AS
BEGIN
	
	SELECT Id, Name,CurrentFlag
	FROM Finance.AccountingYear WITH (NOLOCK)
   
END
CREATE PROCEDURE [Finance].[AccountingYearReadAllActive]
AS
BEGIN
	
	SELECT Id, Name,CurrentFlag
	FROM Finance.AccountingYear WITH (NOLOCK)
	WHERE IsActive = 1
   
END
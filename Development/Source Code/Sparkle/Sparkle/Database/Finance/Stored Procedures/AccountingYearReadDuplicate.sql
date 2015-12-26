CREATE PROCEDURE [Finance].[AccountingYearReadDuplicate]
(
	@Name Varchar(50)
)
AS
BEGIN

	SELECT Id
	FROM Finance.AccountingYear WITH (NOLOCK)
	WHERE Name = @Name
				
END
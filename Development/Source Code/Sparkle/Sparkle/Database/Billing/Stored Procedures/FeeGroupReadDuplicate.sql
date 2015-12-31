CREATE PROCEDURE Billing.FeeGroupReadDuplicate
(
	@Name Varchar(50)
)
AS
BEGIN

	SELECT Id
	FROM Billing.FeeGroup WITH (NOLOCK)
	WHERE Name = @Name
				
END
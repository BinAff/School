CREATE PROCEDURE Billing.FineTypeReadDuplicate
(
	@Name Varchar(50)
)
AS
BEGIN

	SELECT Id
	FROM Billing.FineType WITH (NOLOCK)
	WHERE Name = @Name
				
END
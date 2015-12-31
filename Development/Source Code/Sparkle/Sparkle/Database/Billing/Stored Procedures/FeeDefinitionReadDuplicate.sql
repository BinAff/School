CREATE PROCEDURE Billing.FeeDefinitionReadDuplicate
(
	@Name Varchar(50)
)
AS
BEGIN

	SELECT Id
	FROM Billing.FeeDefinition WITH (NOLOCK)
	WHERE Name = @Name
				
END
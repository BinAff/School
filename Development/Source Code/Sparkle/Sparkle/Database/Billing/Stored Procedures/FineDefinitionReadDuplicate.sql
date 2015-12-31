CREATE PROCEDURE [Billing].[FineDefinitionReadDuplicate]
(
	@Name Varchar(50)
)
AS
BEGIN

	SELECT Id
	FROM Billing.FineDefinition WITH (NOLOCK)
	WHERE Name = @Name
				
END
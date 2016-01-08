
CREATE PROCEDURE [Admission].[TestDefinitionReadDuplicate]
(
	@Name BIGINT	
)
AS
BEGIN

	SELECT Id
	FROM Admission.TestDefinition WITH (NOLOCK)
	WHERE Name = @Name
END
CREATE PROCEDURE [Admission].[TestDefinitionReadAllActive]
(
	@Name Varchar(50)
)
AS
BEGIN

	SELECT Id,Name,PassingMarks,IsActive
	FROM Admission.TestDefinition WITH (NOLOCK) where Isactive = 1
END
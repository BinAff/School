CREATE PROCEDURE [Admission].[TestDefinitionReadAll]
AS
BEGIN
	
	SELECT Id,Name,PassingMarks,IsActive
	FROM Admission.TestDefinition WITH (NOLOCK)
   
END
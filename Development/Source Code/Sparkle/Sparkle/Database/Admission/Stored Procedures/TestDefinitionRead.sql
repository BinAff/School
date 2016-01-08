CREATE PROCEDURE [Admission].[TestDefinitionRead]
(
   @Id BIGINT
)
AS
BEGIN
	
   SELECT Id,Name,PassingMarks,IsActive
   FROM Admission.TestDefinition WITH (NOLOCK)
   WHERE Id = @Id
   
END
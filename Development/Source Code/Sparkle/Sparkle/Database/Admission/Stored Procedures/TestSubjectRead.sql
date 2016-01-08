CREATE PROCEDURE [Admission].[TestSubjectRead]
(
   @Id BIGINT
)
AS
BEGIN
	
   SELECT Id,SubjectName,TestDefinitionId,TotalMarks,PassingMarks,IsActive
   FROM Admission.TestSubject WITH (NOLOCK)
   WHERE Id = @Id
   
END
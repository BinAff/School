CREATE PROCEDURE [Admission].[TestSubjectReadAll]
AS
BEGIN
	
	SELECT Id,SubjectName,TestDefinitionId,TotalMarks,PassingMarks,IsActive
	FROM Admission.TestSubject WITH (NOLOCK)
   
END
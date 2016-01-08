CREATE PROCEDURE [Admission].[TestSubjectReadAllActive]

AS

BEGIN

	SELECT Id,SubjectName,TestDefinitionId,TotalMarks,PassingMarks,IsActive
	FROM Admission.TestSubject WITH (NOLOCK) where Isactive = 1
END
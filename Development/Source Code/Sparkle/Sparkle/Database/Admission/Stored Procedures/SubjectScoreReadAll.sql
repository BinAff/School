
CREATE PROCEDURE [Admission].[SubjectScoreReadAll]
AS
BEGIN
	
	SELECT Id,TestId,TestSubjectId,MarksScored
	FROM Admission.SubjectScore WITH (NOLOCK)
   
END
-----
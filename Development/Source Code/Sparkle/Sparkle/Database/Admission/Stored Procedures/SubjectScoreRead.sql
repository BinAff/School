
CREATE PROCEDURE [Admission].[SubjectScoreRead]
(
   @Id BIGINT
)
AS
BEGIN
	
   SELECT Id,TestId,TestSubjectId,MarksScored
   FROM Admission.SubjectScore WITH (NOLOCK)
   WHERE Id = @Id
   
END
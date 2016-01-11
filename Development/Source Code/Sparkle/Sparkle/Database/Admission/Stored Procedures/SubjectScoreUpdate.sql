
CREATE PROCEDURE [Admission].[SubjectScoreUpdate]
(
    @Id BIGINT,
	@TestId BIGINT,
	@TestSubjectId BIGINT,
	@MarksScored BIGINT
	
	)
AS

BEGIN
	
	UPDATE Admission.SubjectScore
	SET	
	 TestId = @TestId,
	 TestSubjectId = @TestSubjectId,
	 MarksScored = @MarksScored
	 WHERE Id = @Id
   END
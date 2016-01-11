CREATE PROCEDURE [Admission].[SubjectScoreReadDuplicate]
(
	@TestId BIGINT,
	@TestSubjectId BIGINT
	
)
AS
BEGIN

	SELECT Id
	FROM Admission.SubjectScore WITH (NOLOCK)
	WHERE TestId = @TestId
	and TestSubjectId = @TestSubjectId
	END
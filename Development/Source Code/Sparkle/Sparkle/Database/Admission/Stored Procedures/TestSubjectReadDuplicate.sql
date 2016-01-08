CREATE PROCEDURE [Admission].[TestSubjectReadDuplicate]
(
	@SubjectName Varchar(80),
	@TestDefinitionId BIGINT
)
AS
BEGIN

	SELECT Id
	FROM Admission.TestSubject WITH (NOLOCK)
	WHERE SubjectName = @SubjectName
	and TestDefinitionId = TestDefinitionId
END
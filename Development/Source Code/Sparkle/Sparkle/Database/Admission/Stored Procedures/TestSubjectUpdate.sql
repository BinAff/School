
CREATE PROCEDURE [Admission].[TestSubjectUpdate]
(
    @Id BIGINT,
	@SubjectName Varchar(80),
	@TestDefinitionId BIGINT,
	@TotalMarks BIGINT,
	@PassingMarks BIGINT
	
	)
AS

BEGIN
	
	UPDATE Admission.TestSubject
	SET	
	 SubjectName = @SubjectName,
	 TestDefinitionId = @TestDefinitionId,
	 TotalMarks = @TotalMarks,
	 PassingMarks = @PassingMarks
	 WHERE Id = @Id
   END
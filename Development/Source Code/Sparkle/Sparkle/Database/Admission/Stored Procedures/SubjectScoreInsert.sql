CREATE PROCEDURE [Admission].[SubjectScoreInsert]
(  
	@TestId BIGINT,
	@TestSubjectId BIGINT,
	@MarksScored BIGINT,
	@Id BIGINT OUTPUT
	)
AS
BEGIN	
	
	INSERT INTO Admission.SubjectScore(TestId,TestSubjectId,MarksScored)
	VALUES(@TestId,@TestSubjectId,@MarksScored)
   
	SET @Id = @@IDENTITY

END
CREATE PROCEDURE [Admission].[TestSubjectInsert]
(  
	@SubjectName Varchar(80),
	@TestDefinitionId BIGINT,
	@TotalMarks BIGINT,
	@PassingMarks BIGINT,
	@Id BIGINT OUTPUT
	)
AS
BEGIN	
	
	INSERT INTO Admission.TestSubject(SubjectName,TestDefinitionId,TotalMarks,PassingMarks,IsActive)
	VALUES(@SubjectName,@TestDefinitionId,@TotalMarks,@PassingMarks,1)
   
	SET @Id = @@IDENTITY

END
CREATE PROCEDURE [Guardian].[SecurityAnswerInsert]
(
	@UserId Numeric(10,0),
	@QuestionId Numeric(10,0),
	@Answer Varchar(50),
	@Id Numeric(10,0) OUT
)
AS
BEGIN

	INSERT INTO Guardian.SecurityAnswer (UserId, QuestionId, Answer)
	VALUES(@UserId, @QuestionId, @Answer)   
	SET @Id = @@IDENTITY
   
END
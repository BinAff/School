CREATE PROCEDURE [Guardian].[SecurityAnswerReadForParent]
(
	@ParentId Numeric(10,0)
)
AS
BEGIN

	SELECT 
		Id,
		UserId,
		QuestionId,
		Answer
	FROM Guardian.SecurityAnswer WITH (NOLOCK)
	WHERE UserId = @ParentId
	   
END
CREATE PROCEDURE [Guardian].[SecurityQuestionReadAll]
AS
BEGIN
	
	SELECT 
		Id,
		Question	
	FROM SecurityQuestion WITH (NOLOCK)
   
END
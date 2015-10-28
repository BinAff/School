CREATE PROCEDURE [Guardian].[SecurityQuestionRead]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	SELECT 
		Question		
	FROM SecurityQuestion WITH (NOLOCK)
	WHERE Id = @Id
   
END
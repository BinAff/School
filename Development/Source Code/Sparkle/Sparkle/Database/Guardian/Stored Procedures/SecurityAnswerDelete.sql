CREATE PROCEDURE [Guardian].[SecurityAnswerDelete]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM Guardian.SecurityAnswer
	WHERE Id = @Id   
   
END
CREATE PROCEDURE [Guardian].[SecurityQuestionDelete]
(
   @Id Numeric(10,0)
)
AS
BEGIN
	
   DELETE 		
   FROM SecurityQuestion
   WHERE Id = @Id   
   
END
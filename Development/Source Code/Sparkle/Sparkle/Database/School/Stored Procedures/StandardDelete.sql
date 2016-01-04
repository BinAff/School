CREATE PROCEDURE [School].[StandardDelete]
(
	@Id BIGINT
)
AS
BEGIN
	
	DELETE 		
	FROM School.Standard
	WHERE Id = @Id   
   
END
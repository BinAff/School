CREATE PROCEDURE [Utility].[ImportanceDelete]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM Utility.Importance
	WHERE Id = @Id   
   
END
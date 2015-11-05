CREATE PROCEDURE Configuration.ReligionDelete
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM Configuration.Religion
	WHERE Id = @Id   
   
END
CREATE PROCEDURE Configuration.CasteDelete
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM Configuration.Caste
	WHERE Id = @Id   
   
END
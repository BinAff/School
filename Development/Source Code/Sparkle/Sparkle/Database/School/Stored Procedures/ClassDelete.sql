create PROCEDURE School.[ClassDelete]
(
	@Id BIGINT
)
AS
BEGIN
	
	DELETE 		
	FROM School.Class
	WHERE Id = @Id   
   
END
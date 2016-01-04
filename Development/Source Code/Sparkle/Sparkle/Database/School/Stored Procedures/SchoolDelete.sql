CREATE PROCEDURE School.SchoolDelete
(
	@Id BIGINT
)
AS
BEGIN
	
	DELETE 		
	FROM School.School
	WHERE Id = @Id   
   
END
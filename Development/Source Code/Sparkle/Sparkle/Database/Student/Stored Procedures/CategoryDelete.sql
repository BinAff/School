CREATE PROCEDURE [Student].[CategoryDelete]
 (
	@Id Numeric(10,0)
 )
 As
 BEGIN
 
	DELETE FROM Student.Category
	WHERE Id = @Id
	
 End
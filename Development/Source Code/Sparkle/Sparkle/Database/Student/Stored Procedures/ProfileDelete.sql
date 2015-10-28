CREATE PROCEDURE [Student].ProfileDelete
 (
	@Id Numeric(10,0)
 )
 As
 BEGIN
 
	DELETE FROM Student.Profile
	WHERE Id = @Id
	
 End
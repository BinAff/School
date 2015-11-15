CREATE PROCEDURE [Student].[GuardianDelete]
 (
	@Id Numeric(10,0)
 )
 As
 BEGIN
 
	DELETE FROM Student.Guardian
	WHERE Id = @Id
	
 End
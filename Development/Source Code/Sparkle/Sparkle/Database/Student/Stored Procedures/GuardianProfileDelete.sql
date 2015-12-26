CREATE PROCEDURE [Student].[GuardianProfileDelete]
 (
	@Id Numeric(10,0)
 )
 As
 BEGIN
 
	DELETE FROM Student.GuardianProfile
	WHERE Id = @Id
	
 End
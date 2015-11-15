CREATE PROCEDURE [Student].[MobileDelete]
 (
	@Id Numeric(10,0)
 )
 As
 BEGIN
 
	DELETE FROM Student.Mobile
	WHERE Id = @Id
	
 End
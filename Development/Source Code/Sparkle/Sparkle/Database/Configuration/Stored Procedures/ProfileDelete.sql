CREATE PROCEDURE Configuration.ProfileDelete
(
	@Id Numeric(10,0)
)
As
BEGIN
 
	DELETE FROM Configuration.Profile
	WHERE Id = @Id
	
End
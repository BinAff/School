CREATE PROCEDURE Configuration.MobileDelete
(
	@Id Numeric(10,0)
)
As
BEGIN

	DELETE FROM Configuration.Mobile
	WHERE Id = @Id
	
End
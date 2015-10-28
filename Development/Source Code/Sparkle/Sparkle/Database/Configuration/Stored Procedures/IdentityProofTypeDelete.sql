CREATE PROCEDURE [Configuration].[IdentityProofTypeDelete]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE FROM [Configuration].IdentityProofType
	WHERE Id = @Id   
   
END
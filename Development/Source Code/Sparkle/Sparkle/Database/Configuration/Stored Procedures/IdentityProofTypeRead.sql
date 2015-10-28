CREATE PROCEDURE [Configuration].[IdentityProofTypeRead]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	SELECT Id, Name
	FROM Configuration.IdentityProofType WITH (NOLOCK)
	WHERE Id = @Id   
	
END
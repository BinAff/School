CREATE PROCEDURE [Configuration].[IdentityProofTypeReadDuplicate]
(
	@Name VARCHAR(150)		
)
AS
BEGIN

	SELECT Id
	FROM Configuration.IdentityProofType WITH (NOLOCK)
	WHERE Name = @Name
				
END
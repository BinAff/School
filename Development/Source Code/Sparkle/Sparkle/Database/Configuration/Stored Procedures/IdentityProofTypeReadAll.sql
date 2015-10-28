CREATE PROCEDURE [Configuration].[IdentityProofTypeReadAll]
AS
BEGIN
	
	SELECT Id, Name
	FROM Configuration.IdentityProofType WITH (NOLOCK)
   
END
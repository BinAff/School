CREATE PROCEDURE [Guardian].[RoleReadAll]
AS
BEGIN

	SELECT Id, Name, Description
	FROM Guardian.Role WITH (NOLOCK)
	
END
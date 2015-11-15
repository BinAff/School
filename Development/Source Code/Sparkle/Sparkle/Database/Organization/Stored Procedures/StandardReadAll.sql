CREATE PROCEDURE [Organization].[StandardReadAll]
AS
BEGIN
	
	SELECT Id, Name
	FROM Organization.Standard WITH (NOLOCK)
   
END

CREATE PROCEDURE [Configuration].[InitialReadAll]
AS
BEGIN
	
	SELECT Id, Name
	FROM Configuration.Initial WITH (NOLOCK)
   
END
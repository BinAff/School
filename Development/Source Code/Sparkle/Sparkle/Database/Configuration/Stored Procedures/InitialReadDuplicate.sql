CREATE PROCEDURE [Configuration].[InitialReadDuplicate]
(
	@Name VARCHAR(50)		
)
AS
BEGIN

	SELECT Id	
	FROM Configuration.Initial WITH (NOLOCK)
	WHERE Name = @Name
					
END
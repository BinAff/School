CREATE PROCEDURE [Configuration].[StateReadDuplicate]
(
	@Name VARCHAR(50)		
)
AS
BEGIN

	SELECT Id	
	FROM Configuration.State WITH (NOLOCK)
	WHERE Name = @Name	
				
END
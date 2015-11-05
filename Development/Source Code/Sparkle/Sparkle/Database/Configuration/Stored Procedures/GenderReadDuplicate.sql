CREATE PROCEDURE Configuration.GenderReadDuplicate
(
	@Name VARCHAR(50)		
)
AS
BEGIN

	SELECT Id	
	FROM Configuration.Gender WITH (NOLOCK)
	WHERE Name = @Name	
				
END
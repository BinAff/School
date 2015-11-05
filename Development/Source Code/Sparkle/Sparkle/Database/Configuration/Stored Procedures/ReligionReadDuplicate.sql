CREATE PROCEDURE Configuration.ReligionReadDuplicate
(
	@Name VARCHAR(50)		
)
AS
BEGIN

	SELECT Id	
	FROM Configuration.Religion WITH (NOLOCK)
	WHERE Name = @Name	
				
END
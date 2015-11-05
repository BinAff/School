CREATE PROCEDURE Configuration.GenderReadAll
AS
BEGIN
	
	SELECT Id, Name
	FROM Configuration.Gender WITH (NOLOCK)
   
END
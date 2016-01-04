CREATE PROCEDURE School.[StandardReadAll]
AS
BEGIN
	
	SELECT Id, Name, IsActive
	FROM School.Standard WITH (NOLOCK)
   
END
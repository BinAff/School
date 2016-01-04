CREATE PROCEDURE School.[SectionReadAll]
AS
BEGIN
	
	SELECT Id, Name, IsActive
	FROM School.Section WITH (NOLOCK)
   
END
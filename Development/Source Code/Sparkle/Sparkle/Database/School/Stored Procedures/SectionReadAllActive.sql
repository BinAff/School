CREATE PROCEDURE [School].[SectionReadAllActive]
AS
BEGIN
	
	SELECT Id, Name, IsActive
	FROM School.Section WITH (NOLOCK)
	WHERE IsActive = 'True'
   
END
CREATE PROCEDURE [School].[StandardReadAllActive]
AS
BEGIN
	
	SELECT Id, Name, IsActive
	FROM School.Standard WITH (NOLOCK)
	WHERE IsActive = 'True'
   
END
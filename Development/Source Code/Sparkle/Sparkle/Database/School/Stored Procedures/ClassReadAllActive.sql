create PROCEDURE School.[ClassReadAllActive]
AS
BEGIN
	
	SELECT Id, StandardId, SectionId, IsActive
	FROM School.Class WITH (NOLOCK)
	WHERE IsActive = 'True'
   
END
create PROCEDURE School.[ClassReadAll]
AS
BEGIN
	
	SELECT Id, StandardId, SectionId, IsActive
	FROM School.Class WITH (NOLOCK)
   
END
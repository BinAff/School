CREATE PROCEDURE [Organization].[ClassReadAll]
AS
BEGIN
	
	SELECT Id, StandardId,SectionId
	FROM Organization.Class WITH (NOLOCK)
   
END

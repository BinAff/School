CREATE PROCEDURE [Organization].[SectionReadAll]
AS
BEGIN
	
	SELECT Id, Name
	FROM Organization.Section WITH (NOLOCK)
   
END

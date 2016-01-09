CREATE PROCEDURE [Configuration].[OccupationReadAll]
AS
BEGIN
	
	SELECT Id, Name, IsActive
	FROM Configuration.Occupation WITH (NOLOCK)
   
END

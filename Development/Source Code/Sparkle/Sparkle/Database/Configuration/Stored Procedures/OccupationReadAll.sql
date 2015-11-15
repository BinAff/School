CREATE PROCEDURE [Configuration].[OccupationReadAll]
AS
BEGIN
	
	SELECT Id, Name
	FROM Configuration.Occupation WITH (NOLOCK)
   
END

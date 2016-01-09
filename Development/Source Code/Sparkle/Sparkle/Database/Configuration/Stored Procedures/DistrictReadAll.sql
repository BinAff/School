CREATE PROCEDURE [Configuration].[DistrictReadAll]
AS
BEGIN
	
	SELECT Id, Name, StateId, IsActive
	FROM Configuration.District WITH (NOLOCK)
   
END

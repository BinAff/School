CREATE PROCEDURE [Configuration].[DistrictReadAll]
AS
BEGIN
	
	SELECT Id, Name, StateId
	FROM Configuration.District WITH (NOLOCK)
   
END

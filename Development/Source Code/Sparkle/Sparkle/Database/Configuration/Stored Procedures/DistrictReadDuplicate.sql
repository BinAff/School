CREATE PROCEDURE [Configuration].[DistrictReadDuplicate]
(
	@Name Varchar(50),
	@StateId Numeric (10,0)

)
AS
BEGIN

	SELECT Id
	FROM Configuration.District WITH (NOLOCK)
	WHERE Name = @Name
	and  StateId = @StateId
				
END
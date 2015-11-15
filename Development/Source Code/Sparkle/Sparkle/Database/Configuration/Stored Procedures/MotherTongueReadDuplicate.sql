CREATE PROCEDURE [Configuration].[MotherTongueReadDuplicate]
(
	@Name Varchar(50)
	

)
AS
BEGIN

	SELECT Id
	FROM Configuration.MotherTongue WITH (NOLOCK)
	WHERE Name = @Name
				
END
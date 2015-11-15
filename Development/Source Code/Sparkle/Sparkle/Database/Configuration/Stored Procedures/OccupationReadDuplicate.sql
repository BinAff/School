CREATE PROCEDURE [Configuration].[OccupationReadDuplicate]
(
	@Name Varchar(50)
)
AS
BEGIN

	SELECT Id
	FROM Configuration.Occupation WITH (NOLOCK)
	WHERE Name = @Name
				
END
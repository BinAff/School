CREATE PROCEDURE [Organization].[StandardReadDuplicate]
(
	@Name Varchar(50)
)
AS
BEGIN

	SELECT Id
	FROM Organization.Standard WITH (NOLOCK)
	WHERE Name = @Name
				
END
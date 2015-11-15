CREATE PROCEDURE [Organization].[SectionReadDuplicate]
(
	@Name Varchar(50)
)
AS
BEGIN

	SELECT Id
	FROM Organization.Section WITH (NOLOCK)
	WHERE Name = @Name
				
END
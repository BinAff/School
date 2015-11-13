CREATE PROCEDURE Configuration.SubCasteReadDuplicate
(
	@Name Varchar(50)
	

)
AS
BEGIN

	SELECT Id	
	FROM Configuration.SubCaste WITH (NOLOCK)
	WHERE Name = @Name
				
END
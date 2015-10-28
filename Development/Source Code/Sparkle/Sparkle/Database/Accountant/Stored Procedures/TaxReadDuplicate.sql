create PROCEDURE Accountant.[TaxReadDuplicate]
(
	@Name VARCHAR(50)		
)
AS
BEGIN

	SELECT Id	
	FROM Accountant.Tax WITH (NOLOCK)
	WHERE Name = @Name
				
END
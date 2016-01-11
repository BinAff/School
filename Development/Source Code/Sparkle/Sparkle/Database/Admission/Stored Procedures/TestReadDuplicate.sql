CREATE PROCEDURE [Admission].[TestReadDuplicate]
(
	@Name Varchar(80)
	
)
AS
BEGIN

	SELECT Id
	FROM Admission.Test WITH (NOLOCK)
	WHERE Name = @Name
	END
CREATE PROCEDURE [Configuration].[PaymentModeReadDuplicate]
(
	@Name Varchar(50)
)
AS
BEGIN

	SELECT Id
	FROM Configuration.PaymentMode WITH (NOLOCK)
	WHERE Name = @Name
				
END
CREATE PROCEDURE [Finance].[PaymentModeReadDuplicate]
(
	@Name Varchar(50)
)
AS
BEGIN

	SELECT Id
	FROM Finance.PaymentMode WITH (NOLOCK)
	WHERE Name = @Name
				
END
CREATE PROCEDURE [Configuration].[PaymentModeUpdate]
(
	@Id Numeric(10,0),
	@Name Varchar(50)
	)
AS

BEGIN
	
	UPDATE Configuration.PaymentMode
	SET	
		Name = @Name
		WHERE Id = @Id
   END
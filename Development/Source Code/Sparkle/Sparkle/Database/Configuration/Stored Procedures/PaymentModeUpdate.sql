CREATE PROCEDURE [Configuration].[PaymentModeUpdate]
(
	@Id BIGINT,
	@Name Varchar(50)
	)
AS

BEGIN
	
	UPDATE Configuration.PaymentMode
	SET	
		Name = @Name
		WHERE Id = @Id
   END
CREATE PROCEDURE [Finance].[PaymentModeUpdate]
(
	@Id BIGINT,
	@Name Varchar(50)
)
AS
BEGIN
	
	UPDATE Finance.PaymentMode
	SET	
		Name = @Name
	WHERE Id = @Id

END
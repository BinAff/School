CREATE PROCEDURE [Finance].[PaymentModeUpdateStatus]
(
	@Id BIGINT,
	@IsActive BIT
)
AS
BEGIN
	
	UPDATE Finance.PaymentMode
	SET	
		IsActive = @IsActive
	WHERE Id = @Id

END
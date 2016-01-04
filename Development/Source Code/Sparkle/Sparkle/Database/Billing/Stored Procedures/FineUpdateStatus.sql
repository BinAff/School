CREATE PROCEDURE [Billing].[FineUpdateStatus]
(
	@Id BIGINT,
	@IsActive BIT
)
AS
BEGIN
	
	UPDATE Billing.Fine
	SET	
		IsActive = @IsActive
	WHERE Id = @Id

END
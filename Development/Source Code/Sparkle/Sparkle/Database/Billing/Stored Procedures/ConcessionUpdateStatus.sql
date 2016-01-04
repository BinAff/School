CREATE PROCEDURE [Billing].[ConcessionUpdateStatus]
(
	@Id BIGINT,
	@IsActive BIT
)
AS
BEGIN
	
	UPDATE Billing.Concession
	SET	
		IsActive = @IsActive
	WHERE Id = @Id

END
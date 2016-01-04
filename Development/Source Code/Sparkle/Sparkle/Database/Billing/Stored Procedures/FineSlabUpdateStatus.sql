
CREATE PROCEDURE [Billing].[FineSlabUpdateStatus]
(
	@Id BIGINT,
	@IsActive BIT
)
AS
BEGIN
	
	UPDATE Billing.FineSlab
	SET	
		IsActive = @IsActive
	WHERE Id = @Id

END
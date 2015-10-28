CREATE PROCEDURE Organization.UnitClosureReasonUpdate
(
	@Id Numeric(10,0),
	@Reason Varchar(50),
	@UnitId Numeric(10,0),
	@ClosedDate DateTime
)
AS
BEGIN
	
	UPDATE Organization.UnitClosureReason
	SET
		UnitId = @UnitId,
		Reason = @Reason,
		ClosedDate = @ClosedDate
	FROM Organization.UnitClosureReason WITH (NOLOCK)
	WHERE Id = @Id
	
END
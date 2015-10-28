CREATE PROCEDURE Organization.UnitClosureReasonInsert
(  
	@Reason Varchar(50),
	@UnitId Numeric(10,0),
	@Id  Numeric(10,0) OUTPUT
)
AS
BEGIN	
	
	INSERT INTO Organization.UnitClosureReason(Reason, UnitId, ClosedDate)
	VALUES(@Reason, @UnitId, GETDATE())
   
	SET @Id = @@IDENTITY
	
END
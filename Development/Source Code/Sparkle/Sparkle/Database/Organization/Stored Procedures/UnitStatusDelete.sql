CREATE PROCEDURE  Organization.UnitStatusDelete
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE FROM Organization.UnitStatus
	WHERE Id = @Id
	
END
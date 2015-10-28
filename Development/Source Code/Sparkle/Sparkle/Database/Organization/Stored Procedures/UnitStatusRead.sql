CREATE PROCEDURE Organization.UnitStatusRead
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	SELECT Id, Name
	FROM Organization.UnitStatus WITH (NOLOCK)
	WHERE Id = @Id   
	
END
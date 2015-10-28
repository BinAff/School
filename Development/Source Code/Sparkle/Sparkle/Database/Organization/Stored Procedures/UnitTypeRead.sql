CREATE PROCEDURE Organization.UnitTypeRead
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	SELECT Id, Name
	FROM Organization.UnitType WITH (NOLOCK)
	WHERE Id = @Id   
	
END
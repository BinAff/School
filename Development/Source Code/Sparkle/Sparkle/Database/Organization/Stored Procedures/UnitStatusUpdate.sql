CREATE PROCEDURE Organization.UnitStatusUpdate
(	
	@Id Numeric(10,0),
	@Name Varchar(50)
)
AS
BEGIN
	
	UPDATE Organization.UnitStatus
	SET	
		Name = @Name
	WHERE Id = @Id
   
END
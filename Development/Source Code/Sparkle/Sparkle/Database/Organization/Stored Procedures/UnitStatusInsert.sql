CREATE PROCEDURE Organization.UnitStatusInsert
(  
	@Name Varchar(50),	
	@Id  Numeric(10,0) OUTPUT
)
AS
BEGIN	
	
	INSERT INTO Organization.UnitStatus(Name)
	VALUES(@Name)
   
	SET @Id = @@IDENTITY
	
END
CREATE PROCEDURE Organization.UnitTypeInsert
	(  
		@Name Varchar(50),	
		@Id  Numeric(10,0) OUTPUT
	)
	AS
	BEGIN
		
		INSERT INTO Organization.UnitType(Name)
		VALUES(@Name)
	   
		SET @Id = @@IDENTITY
	END
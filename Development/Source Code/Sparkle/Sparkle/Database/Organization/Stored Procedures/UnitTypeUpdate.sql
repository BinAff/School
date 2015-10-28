CREATE PROCEDURE Organization.UnitTypeUpdate
	(	
		@Id Numeric(10,0),
		@Name Varchar(50)
	)
	AS
	BEGIN
		
		UPDATE Organization.UnitType
		SET	
			Name = @Name
		WHERE Id = @Id
	   
	END
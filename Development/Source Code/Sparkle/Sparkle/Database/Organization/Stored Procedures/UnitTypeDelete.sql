CREATE PROCEDURE  Organization.UnitTypeDelete
	(
		@Id Numeric(10,0)
	)
	AS
	BEGIN
		
		DELETE 		
		FROM Organization.UnitType
		WHERE Id = @Id      
	END
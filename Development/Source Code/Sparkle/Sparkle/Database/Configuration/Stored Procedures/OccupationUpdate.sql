CREATE PROCEDURE [Configuration].[OccupationUpdate]
(
	@Id Numeric(10,0),
	@Name Varchar(50)
)
AS

BEGIN
	
	UPDATE Configuration.Occupation
	SET	
		Name = @Name
		WHERE Id = @Id
   END
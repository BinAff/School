CREATE PROCEDURE Configuration.MotherTongueUpdate
(
	@Id Numeric(10,0),
	@Name Varchar(50)
)
AS

BEGIN
	
	UPDATE Configuration.MotherTongue
	SET	
		Name = @Name
		WHERE Id = @Id
   END
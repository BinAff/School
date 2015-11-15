CREATE PROCEDURE [Organization].[StandardUpdate]
(
	@Id Numeric(10,0),
	@Name Varchar(50)
	
)
AS

BEGIN
	
	UPDATE Organization.Standard
	SET	
		Name = @Name
		WHERE Id = @Id
   END
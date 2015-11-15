CREATE PROCEDURE [Organization].[SectionUpdate]
(
	@Id Numeric(10,0),
	@Name Varchar(50)
	
)
AS

BEGIN
	
	UPDATE Organization.Section
	SET	
		Name = @Name
		WHERE Id = @Id
   END
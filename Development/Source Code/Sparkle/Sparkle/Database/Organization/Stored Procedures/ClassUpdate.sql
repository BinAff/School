CREATE PROCEDURE [Organization].[ClassUpdate]
(
	@Id Numeric(10,0),
	@StandardId Numeric (10,0),
	@SectionId Numeric (10,0)
)
AS

BEGIN
	
	UPDATE Organization.Class
	SET	
		StandardId = @StandardId,
		SectionId = @SectionId
		WHERE Id = @Id
   END
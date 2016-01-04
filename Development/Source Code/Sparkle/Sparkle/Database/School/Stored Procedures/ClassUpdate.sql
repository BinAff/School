create PROCEDURE School.[ClassUpdate]
(
	@Id BIGINT,
	@StandardId BIGINT,
	@SectionId BIGINT
)
AS

BEGIN
	
	UPDATE School.Class
	SET	
		StandardId = @StandardId,
		SectionId = @SectionId
		WHERE Id = @Id
   END
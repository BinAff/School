create PROCEDURE School.[ClassReadDuplicate]
(
	@StandardId BIGINT,
	@SectionId BIGINT
)
AS
BEGIN

	SELECT Id
	FROM School.Class WITH (NOLOCK)
	WHERE StandardId = @StandardId
		AND SectionId = @SectionId
				
END
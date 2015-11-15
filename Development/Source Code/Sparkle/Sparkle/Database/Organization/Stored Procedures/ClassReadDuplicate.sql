CREATE PROCEDURE [Organization].[ClassReadDuplicate]
(
	@StandardId Numeric (10,0),
	@SectionId  Numeric (10,0)
)
AS
BEGIN

	SELECT Id
	FROM Organization.Class WITH (NOLOCK)
	WHERE StandardId = @StandardId
	and SectionId = @SectionId
				
END
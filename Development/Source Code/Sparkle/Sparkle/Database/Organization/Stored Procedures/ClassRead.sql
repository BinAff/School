CREATE PROCEDURE [Organization].[ClassRead]
(
	@Id Numeric(10,0) = null
)
AS
BEGIN

	SELECT  Id, StandardId,SectionId
	FROM Organization.Class WITH (NOLOCK)
	WHERE Id = @Id
	
END
create PROCEDURE School.[ClassRead]
(
	@Id BIGINT
)
AS
BEGIN

	SELECT  Id, StandardId, SectionId, IsActive
	FROM School.Class WITH (NOLOCK)
	WHERE Id = @Id
	
END
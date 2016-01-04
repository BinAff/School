CREATE PROCEDURE [School].[SectionRead]
(
	@Id BIGINT
)
AS
BEGIN

	SELECT  Id, Name, IsActive
	FROM School.Section WITH (NOLOCK)
	WHERE Id = @Id
	
END
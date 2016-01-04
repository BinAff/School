CREATE PROCEDURE School.[StandardRead]
(
	@Id BIGINT
)
AS
BEGIN

	SELECT  Id, Name, IsActive
	FROM School.Standard WITH (NOLOCK)
	WHERE Id = @Id
	
END
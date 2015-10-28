CREATE PROCEDURE [Guardian].[RoleRead]
(
	@Id Numeric(10,0)
)
AS
BEGIN

	SELECT Id, Name, [Description]
	FROM  Guardian.[Role] WITH (NOLOCK)
	WHERE Id = @Id
	
END
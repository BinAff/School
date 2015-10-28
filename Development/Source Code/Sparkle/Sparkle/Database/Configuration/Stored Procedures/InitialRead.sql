CREATE PROCEDURE [Configuration].[InitialRead]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	SELECT Id, Name
	FROM Configuration.Initial WITH (NOLOCK)
	WHERE Id = @Id   
	
END
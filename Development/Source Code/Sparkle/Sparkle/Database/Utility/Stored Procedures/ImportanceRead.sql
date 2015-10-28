CREATE PROCEDURE [Utility].[ImportanceRead]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	SELECT Id, Name
	FROM Utility.Importance WITH (NOLOCK)
	WHERE Id = @Id   
	
END
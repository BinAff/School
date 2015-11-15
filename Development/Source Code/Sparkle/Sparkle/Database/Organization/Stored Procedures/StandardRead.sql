CREATE PROCEDURE [Organization].[StandardRead]
(
	@Id Numeric(10,0) 
)
AS
BEGIN

	SELECT  Id, Name
	FROM Organization.Standard WITH (NOLOCK)
	WHERE Id = @Id
	
END
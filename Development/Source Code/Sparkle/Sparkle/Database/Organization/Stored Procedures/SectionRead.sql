CREATE PROCEDURE [Organization].[SectionRead]
(
	@Id Numeric(10,0) 
)
AS
BEGIN

	SELECT  Id, Name
	FROM Organization.Section WITH (NOLOCK)
	WHERE Id = @Id
	
END
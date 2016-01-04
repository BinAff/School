CREATE PROCEDURE [School].[SectionDelete]
(
	@Id BIGINT
)
AS
BEGIN
	
	DELETE 		
	FROM School.Section
	WHERE Id = @Id   
   
END
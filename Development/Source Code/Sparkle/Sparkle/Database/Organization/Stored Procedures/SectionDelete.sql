CREATE PROCEDURE [Organization].[SectionDelete]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM [Organization].[Section]
	WHERE Id = @Id   
   
END
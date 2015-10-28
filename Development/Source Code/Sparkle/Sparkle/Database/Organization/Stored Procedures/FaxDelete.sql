CREATE PROCEDURE [Organization].[FaxDelete]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM [Organization].[Fax]
	WHERE Id = @Id 
END
CREATE PROCEDURE [Admission].[TestDefinitionDelete]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM Admission.TestDefinition
	WHERE Id = @Id   
   
END
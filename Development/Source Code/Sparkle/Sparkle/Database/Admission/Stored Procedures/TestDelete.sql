CREATE PROCEDURE [Admission].[TestDelete]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM Admission.Test
	WHERE Id = @Id   
   
END
CREATE PROCEDURE [Admission].[TestSubjectDelete]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM Admission.TestSubject
	WHERE Id = @Id   
   
END
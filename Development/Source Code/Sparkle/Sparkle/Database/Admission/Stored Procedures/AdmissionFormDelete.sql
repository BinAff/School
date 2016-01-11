CREATE PROCEDURE [Admission].[AdmissionFormDelete]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM Admission.AdmissionForm
	WHERE Id = @Id   
   
END
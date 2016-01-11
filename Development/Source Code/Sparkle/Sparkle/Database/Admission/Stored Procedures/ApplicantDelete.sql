CREATE PROCEDURE [Admission].[ApplicantDelete]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM Admission.Applicant
	WHERE Id = @Id   
   
END
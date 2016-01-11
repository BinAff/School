CREATE PROCEDURE [Admission].[AdmissionFormRead]
(
   @Id BIGINT
)
AS
BEGIN
	
   SELECT Id,AdmissionNumber,DateOfIssue,Remarks,FeesId,Applicantid
   FROM Admission.AdmissionForm WITH (NOLOCK)
   WHERE Id = @Id
   
END
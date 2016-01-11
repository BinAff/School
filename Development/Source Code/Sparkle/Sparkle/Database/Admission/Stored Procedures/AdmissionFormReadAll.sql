CREATE PROCEDURE [Admission].[AdmissionFormReadAll]
AS
BEGIN
	
	SELECT Id,AdmissionNumber,DateOfIssue,Remarks,FeesId,Applicantid
	FROM Admission.AdmissionForm WITH (NOLOCK)
   
END
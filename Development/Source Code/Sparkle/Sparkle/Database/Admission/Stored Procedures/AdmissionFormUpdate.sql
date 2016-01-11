CREATE PROCEDURE [Admission].[AdmissionFormUpdate]
(
    @Id BIGINT,
	@AdmissionNumber Varchar(20),
	@DateOfIssue Date,
	@Remarks Varchar(100) = NULL,
	@FeesId BIGINT = NULL,
	@Applicantid BIGINT
	)
AS

BEGIN
	
	UPDATE Admission.AdmissionForm
	SET	
	 AdmissionNumber = @AdmissionNumber,
	 DateOfIssue = @DateOfIssue,
	 Remarks = @Remarks,
	 FeesId = @FeesId,
	 Applicantid = @Applicantid
	 WHERE Id = @Id
   END
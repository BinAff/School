CREATE PROCEDURE [Admission].[AdmissionFormInsert]
(  
	@AdmissionNumber Varchar(20),
	@DateOfIssue Date,
	@Remarks Varchar(100) = NULL,
	@FeesId BIGINT = NULL,
	@Applicantid BIGINT,
	@Id BIGINT OUTPUT
	)
AS
BEGIN	
	
	INSERT INTO Admission.AdmissionForm(AdmissionNumber,DateOfIssue,Remarks,FeesId,Applicantid)
	VALUES(@AdmissionNumber,@DateOfIssue,@Remarks,@FeesId,@Applicantid)
   
	SET @Id = @@IDENTITY

END
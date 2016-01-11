CREATE PROCEDURE [Admission].[ApplicantRead]
(
   @Id BIGINT
)
AS
BEGIN
	
   SELECT Id,FirstName,MiddleName,LastName,PersonalInformationId,StandardId,FatherName,FatherOccupation,FatherMonthlyIncome,
	MotherName,MotherOccupation,MotherMonthlyIncome,EducationBackgroundId,TestId
   FROM Admission.Applicant WITH (NOLOCK)
   WHERE Id = @Id
   
END
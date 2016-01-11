CREATE PROCEDURE [Admission].[ApplicantUpdate]
(
    @Id BIGINT,
	@FirstName Varchar(100),
	@MiddleName Varchar(100) = NULL,
	@LastName Varchar(100) = NULL,
	@PersonalInformationId BIGINT = NULL,
	@StandardId BIGINT = NULL,
	@FatherName Varchar(100) = NULL,
	@FatherOccupation Varchar(100) = NULL,
	@FatherMonthlyIncome BIGINT = NULL,
	@MotherName Varchar(100) = NULL,
	@MotherOccupation Varchar(100) = NULL,
	@MotherMonthlyIncome BIGINT = NULL,
	@EducationBackgroundId BIGINT = NULL,
	@TestId BIGINT = NULL
	)
AS

BEGIN
	
	UPDATE Admission.Applicant
	SET	
	 FirstName = @FirstName,
	 MiddleName = @MiddleName,
	 LastName = @LastName,
	 PersonalInformationId = @PersonalInformationId,
	 StandardId = @StandardId,
	 FatherName = @FatherName,
	 FatherOccupation =  @FatherOccupation,
	 FatherMonthlyIncome = @FatherMonthlyIncome,
	 MotherName = @MotherName,
	 MotherOccupation = @MotherOccupation,
	 MotherMonthlyIncome = @MotherMonthlyIncome,
	 EducationBackgroundId = @EducationBackgroundId,
	 TestId = @TestId
	 WHERE Id = @Id
   END
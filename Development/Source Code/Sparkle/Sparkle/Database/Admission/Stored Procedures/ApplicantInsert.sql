CREATE PROCEDURE [Admission].[ApplicantInsert]
(  
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
	@TestId BIGINT = NULL,
	@Id BIGINT OUTPUT
	)
AS
BEGIN	
	
	INSERT INTO Admission.Applicant(FirstName,MiddleName,LastName,PersonalInformationId,StandardId,FatherName,FatherOccupation,FatherMonthlyIncome,
	MotherName,MotherOccupation,MotherMonthlyIncome,EducationBackgroundId,TestId)
	VALUES(@FirstName,@MiddleName,@LastName,@PersonalInformationId,@StandardId,@FatherName,@FatherOccupation,@FatherMonthlyIncome,
	@MotherName,@MotherOccupation,@MotherMonthlyIncome,@EducationBackgroundId,@TestId)
   
	SET @Id = @@IDENTITY

END
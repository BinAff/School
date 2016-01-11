CREATE PROCEDURE [Admission].[EducationBackgroundInsert]
(  
	@PreviousStandard Varchar(80),
	@PreviousSchool Varchar(80),
	@PreviousPercent BIGINT = NULL,
	@Id BIGINT OUTPUT
	)
AS
BEGIN	
	
	INSERT INTO Admission.EducationBackground(PreviousStandard,PreviousSchool,PreviousPercent)
	VALUES(@PreviousStandard,@PreviousSchool,@PreviousPercent)
   
	SET @Id = @@IDENTITY

END
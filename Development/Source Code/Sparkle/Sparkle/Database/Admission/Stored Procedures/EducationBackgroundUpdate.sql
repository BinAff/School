
CREATE PROCEDURE [Admission].[EducationBackgroundUpdate]
(
    @Id BIGINT,
	@PreviousStandard Varchar(80),
	@PreviousSchool Varchar(80),
	@PreviousPercent BIGINT
	)
AS

BEGIN
	
	UPDATE Admission.EducationBackground
	SET	
	 PreviousStandard = @PreviousStandard,
	 PreviousSchool = @PreviousSchool,
	 PreviousPercent = @PreviousPercent
	 WHERE Id = @Id
   END
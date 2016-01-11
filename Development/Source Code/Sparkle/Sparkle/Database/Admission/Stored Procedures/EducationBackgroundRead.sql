
CREATE PROCEDURE [Admission].[EducationBackgroundRead]
(
   @Id BIGINT
)
AS
BEGIN
	
   SELECT Id,PreviousStandard,PreviousSchool,PreviousPercent
   FROM Admission.EducationBackground WITH (NOLOCK)
   WHERE Id = @Id
   
END
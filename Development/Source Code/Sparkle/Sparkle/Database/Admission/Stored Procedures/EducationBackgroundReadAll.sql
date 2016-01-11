
CREATE PROCEDURE [Admission].[EducationBackgroundReadAll]
AS
BEGIN
	
	SELECT Id,PreviousStandard,PreviousSchool,PreviousPercent
	FROM Admission.EducationBackground WITH (NOLOCK)
   
END
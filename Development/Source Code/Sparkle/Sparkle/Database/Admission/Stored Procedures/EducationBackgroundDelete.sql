CREATE PROCEDURE [Admission].[EducationBackgroundDelete]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM Admission.EducationBackground
	WHERE Id = @Id   
   
END
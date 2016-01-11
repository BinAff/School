CREATE PROCEDURE [Admission].[SubjectScoreDelete]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM Admission.SubjectScore
	WHERE Id = @Id   
   
END
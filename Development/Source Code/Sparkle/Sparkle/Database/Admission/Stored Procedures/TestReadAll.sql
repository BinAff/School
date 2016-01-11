CREATE PROCEDURE [Admission].[TestReadAll]
AS
BEGIN
	
	SELECT Id,Name,TestDefinitionId,TotalScore,TestRank
	FROM Admission.Test WITH (NOLOCK)
   
END
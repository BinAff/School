CREATE PROCEDURE [Admission].[TestRead]
(
   @Id BIGINT
)
AS
BEGIN
	
   SELECT Id,Name,TestDefinitionId,TotalScore,TestRank
   FROM Admission.Test WITH (NOLOCK)
   WHERE Id = @Id
   
END
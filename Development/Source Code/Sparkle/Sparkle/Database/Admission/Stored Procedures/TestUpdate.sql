CREATE PROCEDURE [Admission].[TestUpdate]
(
    @Id BIGINT,
	@Name Varchar(80),
	@TestDefinitionId BIGINT,
	@TotalScore BIGINT,
	@IsPassed BIT,
	@TestRank BIGINT
	
	)
AS

BEGIN
	
	UPDATE Admission.Test
	SET	
	 Name = @Name,
	 TestDefinitionId = @TestDefinitionId,
	 TotalScore = @TotalScore,
	 IsPassed = @IsPassed,
	 TestRank = @TestRank
	 WHERE Id = @Id
   END
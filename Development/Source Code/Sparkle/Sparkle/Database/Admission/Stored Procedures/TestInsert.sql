CREATE PROCEDURE [Admission].[TestInsert]
(  
	@TestDefinitionId BIGINT,
	@Name Varchar(80),
	@TotalScore BIGINT = Null,
	@IsPassed BIT,
	@TestRank BIGINT = Null,
	@Id BIGINT OUTPUT
	)
AS
BEGIN	
	
	INSERT INTO Admission.Test(Name,TestDefinitionId,TotalScore,TestRank)
	VALUES(@Name,@TestDefinitionId,@TotalScore,@TestRank)
   
	SET @Id = @@IDENTITY

END
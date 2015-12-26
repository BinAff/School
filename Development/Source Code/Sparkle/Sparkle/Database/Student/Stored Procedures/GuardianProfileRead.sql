CREATE PROCEDURE [Student].[GuardianProfileRead]
(
	@Id Numeric(10,0)
)
As
BEGIN

	SELECT  Id,FirstName,MiddleName,LastName,OccupationId,ContactInformationId
	 FROM Student.GuardianProfile WITH (NOLOCK)
	WHERE Id = @Id
	
END
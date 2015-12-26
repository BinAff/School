CREATE PROCEDURE [Student].[GuardianProfileReadAll]
As
BEGIN

	SELECT Id, FirstName,MiddleName,LastName,OccupationId,ContactInformationId
			FROM Student.GuardianProfile WITH (NOLOCK)
	
END
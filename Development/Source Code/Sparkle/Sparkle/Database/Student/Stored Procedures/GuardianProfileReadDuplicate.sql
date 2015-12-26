CREATE PROCEDURE Student.GuardianProfileReadDuplicate
(
	@FirstName  Varchar(50),
	@MiddleName  Varchar(50),
	@LastName  Varchar(50),
	@OccupationId  Bigint,
	@ContactInformationId Bigint
)
AS
BEGIN

	SELECT Id	
	FROM Student.GuardianProfile WITH (NOLOCK)
	WHERE FirstName = @FirstName
	and MiddleName = @MiddleName
	and LastName = @LastName
	and OccupationId = @OccupationId
	and ContactInformationId = @ContactInformationId
				
END
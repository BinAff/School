CREATE PROCEDURE [Student].[GuardianProfileInsert]
(
	@FirstName Varchar(100),
	@MiddleName Varchar(100),
	@LastName Varchar(100),
	@OccupationId Bigint,
	@ContactInformationId Bigint,
	@Id  Bigint OUTPUT
)
AS
BEGIN

	INSERT INTO Student.GuardianProfile(FirstName,MiddleName,LastName,OccupationId,ContactInformationId)
	VALUES(@FirstName,@MiddleName,@LastName,@OccupationId,@ContactInformationId)   
	SET @Id = @@IDENTITY
	
END
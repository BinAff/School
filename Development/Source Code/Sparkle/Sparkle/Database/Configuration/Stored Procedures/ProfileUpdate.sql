CREATE PROCEDURE Configuration.ProfileUpdate
(  
	@Id  Bigint,
	@FirstName Varchar(50),
	@MiddleName Varchar(50),
	@LastName Varchar(50),
	@OccupationId Bigint,
	@ContactInformationId Bigint
)
AS
BEGIN

	UPDATE Configuration.Profile
	SET
		FirstName = @FirstName,
		MiddleName = @MiddleName,
		LastName = @LastName,
		OccupationId = @OccupationId,
		ContactInformationId = @ContactInformationId
	WHERE Id = @Id

END
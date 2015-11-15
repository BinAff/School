CREATE PROCEDURE [Student].[MobileRead]
(
	@Id Numeric(10,0)
)
As
BEGIN

	SELECT  Id,MobileNumber,GuardianProfileId,CountryId
	 FROM Student.Mobile WITH (NOLOCK)
	WHERE Id = @Id
	
END
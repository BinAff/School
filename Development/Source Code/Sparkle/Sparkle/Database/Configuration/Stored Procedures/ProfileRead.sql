CREATE PROCEDURE Configuration.ProfileRead
(
	@Id Numeric(10,0)
)
As
BEGIN

	SELECT  Id, FirstName, MiddleName, LastName, OccupationId, ContactInformationId
	FROM Configuration.Profile WITH (NOLOCK)
	WHERE Id = @Id
	
END
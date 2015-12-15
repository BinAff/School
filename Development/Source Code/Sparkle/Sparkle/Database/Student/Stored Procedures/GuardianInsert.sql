CREATE PROCEDURE Student.GuardianInsert
(
	@StudentId Bigint,
	@ProfileId Bigint,
	@RelationshipId Bigint,
	@Id  Bigint OUTPUT
)
AS
BEGIN

	INSERT INTO Student.Guardian(StudentId, ProfileId, RelationshipId)
	VALUES(@StudentId, @ProfileId, @RelationshipId)   
	SET @Id = @@IDENTITY
	
END
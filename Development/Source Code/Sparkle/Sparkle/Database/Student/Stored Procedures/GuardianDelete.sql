CREATE PROCEDURE Student.GuardianDelete
(
	@Id Bigint
)
As
BEGIN

	DELETE FROM Student.Guardian
	WHERE Id = @Id
	
END
CREATE PROCEDURE Student.PersonalInformationDelete
(
	@Id Numeric(10,0)
)
As
BEGIN

	DELETE FROM Student.PersonalInformation
	WHERE Id = @Id
	
End
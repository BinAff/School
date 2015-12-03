CREATE PROCEDURE Student.PersonalInformationReadDuplicate
(
	@StudentId Bigint
)
AS
BEGIN

	SELECT Id	
	FROM Student.PersonalInformation WITH (NOLOCK)
	WHERE StudentId = @StudentId
				
END
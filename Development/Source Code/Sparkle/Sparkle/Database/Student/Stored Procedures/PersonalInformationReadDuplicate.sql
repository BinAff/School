CREATE PROCEDURE [Student].[PersonalInformationReadDuplicate]
(
	@StudId Bigint
)
AS
BEGIN

	SELECT Id	
	FROM Student.PersonalInformation WITH (NOLOCK)
	WHERE StudId = @Studid
				
END
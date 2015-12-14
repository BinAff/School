﻿CREATE PROCEDURE Student.PersonalInformationRead
(
	@Id Numeric(10,0)
)
As
BEGIN

	SELECT  Id, StudentId, DateOfBirth, BirthPlace, MothertongueId,
		ReligionId, CasteId, SubCasteId, GenderId, PresentAddressId, PermanentAddressId
	FROM Student.PersonalInformation WITH (NOLOCK)
	WHERE Id = @Id
	
END
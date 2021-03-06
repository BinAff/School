﻿CREATE PROCEDURE [Student].[StudentUpdate]
(  
	@Id  Bigint,
	@StudentId Varchar(50),
	@FirstName Varchar(100),
	@MiddleName Varchar(100),
	@LastName Varchar(100),
	@RollNumber Varchar(50),
	@Photo Varbinary(1024) = null,
	@CategoryId Bigint,
	@StandardId Bigint,
	@SectionId Bigint
)
AS
BEGIN

	UPDATE Student.Student
	SET
		StudentId = @StudentId,
		FirstName = @FirstName,
		MiddleName = @MiddleName,
		LastName = @LastName,
		RollNumber = @RollNumber,
		Photo = @Photo,
		CategoryId = @CategoryId,
		StandardId = @StandardId,
		SectionId = @SectionId
	WHERE Id = @Id

END
CREATE PROCEDURE [Student].[StudentUpdate]
(  
	@Id  Bigint,
	@StudentId Bigint,
	@FirstName Varchar(100),
	@MiddleName Varchar(100),
	@LastName Varchar(100),
	@RollNumber Varchar(50),
	@Photo Varbinary(1024),
	@CategoryId Bigint,
	@ClassId Bigint
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
		ClassId = @ClassId
	WHERE Id = @Id

END
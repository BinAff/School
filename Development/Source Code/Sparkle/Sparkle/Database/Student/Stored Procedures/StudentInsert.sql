CREATE PROCEDURE Student.StudentInsert
(
	@StudentId Varchar(50),
	@FirstName Varchar(100),
	@MiddleName Varchar(100),
	@LastName Varchar(100),
	@RollNumber Varchar(50),
	@Photo Varbinary (1024) = null,
	@CategoryId Bigint,
	@StandardId Bigint,
	@SectionId Bigint,
	@Id  Bigint OUTPUT
)
AS
BEGIN

	INSERT INTO Student.Student (StudentId, FirstName, MiddleName, LastName,
			RollNumber, Photo, CategoryId, StandardId, SectionId)
		VALUES(@StudentId, @FirstName, @MiddleName, @LastName,
			@RollNumber, @Photo, @CategoryId, @StandardId, @SectionId)
	SET @Id = @@IDENTITY
	
END
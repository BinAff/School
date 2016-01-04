create PROCEDURE School.[ClassInsert]
(  
	@StandardId BIGINT,
	@SectionId BIGINT,
	@Id BIGINT OUTPUT
)
AS
BEGIN	
	
	INSERT INTO School.Class(StandardId, SectionId, IsActive)
	VALUES(@StandardId, @SectionId, 'True')
   
	SET @Id = @@IDENTITY
	
END
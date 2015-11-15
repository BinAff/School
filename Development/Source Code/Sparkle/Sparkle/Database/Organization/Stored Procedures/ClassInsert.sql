CREATE PROCEDURE [Organization].[ClassInsert]
(  
	@StandardId Numeric(10,0),
	@SectionId Numeric(10,0),
	@Id  Numeric(10,0) OUTPUT
)
AS
BEGIN	
	
	INSERT INTO [Organization].Class(StandardId,SectionId)
	VALUES(@StandardId,@SectionId)
   
	SET @Id = @@IDENTITY
END
CREATE PROCEDURE [Organization].[SectionInsert]
(  
	@Name Numeric(10,0),
	@Id  Numeric(10,0) OUTPUT
)
AS
BEGIN	
	
	INSERT INTO [Organization].Section(Name)
	VALUES(@Name)
   
	SET @Id = @@IDENTITY
END
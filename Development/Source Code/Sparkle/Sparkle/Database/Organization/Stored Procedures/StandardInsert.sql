CREATE PROCEDURE [Organization].[StandardInsert]
(  
	@Name Numeric(10,0),
	@Id  Numeric(10,0) OUTPUT
)
AS
BEGIN	
	
	INSERT INTO [Organization].Standard(Name)
	VALUES(@Name)
   
	SET @Id = @@IDENTITY
END
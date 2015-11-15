CREATE PROCEDURE [Configuration].[SubCasteInsert]
(  
	@Name Varchar(50),
	@Id  Numeric(10,0) OUTPUT
)
AS
BEGIN	
	
	INSERT INTO Configuration.SubCaste(Name)
	VALUES(@Name)
   
   	SET @Id = @@IDENTITY

END
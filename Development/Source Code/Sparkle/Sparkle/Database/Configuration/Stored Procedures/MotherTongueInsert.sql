CREATE PROCEDURE [Configuration].[MotherTongueInsert]
(  
	@Name Varchar(50),
	@Id  Numeric(10,0) OUTPUT
)
AS
BEGIN	
	
	INSERT INTO Configuration.MotherTongue(Name)
	VALUES(@Name)
   
	SET @Id = @@IDENTITY

END
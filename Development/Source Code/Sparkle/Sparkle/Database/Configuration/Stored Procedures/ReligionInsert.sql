CREATE PROCEDURE [Configuration].[ReligionInsert]
(  
	@Name Varchar(50),
	@Id  Numeric(10,0) OUTPUT
)
AS
BEGIN	
	
	INSERT INTO Configuration.Religion(Name)
	VALUES(@Name)
   
	SET @Id = @@IDENTITY

END
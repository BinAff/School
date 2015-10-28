CREATE PROCEDURE [Configuration].[StateInsert]
(  
	@Name Varchar(50),
	@CountryId Numeric(10,0),
	@Id  Numeric(10,0) OUTPUT
)
AS
BEGIN	
	
	INSERT INTO Configuration.[State](Name, CountryId)
	VALUES(@Name, @CountryId)
   
	SET @Id = @@IDENTITY
END
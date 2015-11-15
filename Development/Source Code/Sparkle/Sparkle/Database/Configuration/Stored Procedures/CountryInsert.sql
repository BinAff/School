CREATE PROCEDURE [Configuration].[CountryInsert]
(  
	@Name Varchar(50),
	@Code Varchar(50),
	@IsdCode Varchar(50),
	@Id  Numeric(10,0) OUTPUT
)
AS
BEGIN	
	
	INSERT INTO Configuration.Country(Name,Code,IsdCode)
	VALUES(@Name,@COde,@IsdCode)
   
	SET @Id = @@IDENTITY

END
CREATE PROCEDURE [Configuration].[InitialInsert]
(  
	@Name Varchar(50),
	@Id  Numeric(10,0) OUTPUT
)
AS
BEGIN	
	
	INSERT INTO [Configuration].Initial([Name])
	VALUES(@Name)
   
	SET @Id = @@IDENTITY
END
CREATE PROCEDURE [Configuration].[CasteInsert]
(  
	@Name Varchar(50),
	@Id  Numeric(10,0) OUTPUT
)
AS
BEGIN	
	
	INSERT INTO Configuration.Caste(Name)
	VALUES(@Name)
   
	SET @Id = @@IDENTITY

END
CREATE PROCEDURE [Configuration].[PaymentModeInsert]
(  
	@Name Varchar(50),
	@IsActive BIT,
	@Id  Numeric(10,0) OUTPUT
)
AS
BEGIN	
	
	INSERT INTO Configuration.PaymentMode(Name,IsActive)
	VALUES(@Name,@IsActive)
   
	SET @Id = @@IDENTITY

END
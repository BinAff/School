CREATE PROCEDURE [Configuration].[PaymentModeInsert]
(  
	@Name Varchar(50),
	@IsActive BIT,
	@Id  BIGINT OUTPUT
)
AS
BEGIN	
	
	INSERT INTO Configuration.PaymentMode(Name,IsActive)
	VALUES(@Name,@IsActive)
   
	SET @Id = @@IDENTITY

END
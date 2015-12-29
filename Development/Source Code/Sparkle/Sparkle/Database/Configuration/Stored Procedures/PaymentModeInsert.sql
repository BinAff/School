CREATE PROCEDURE [Configuration].[PaymentModeInsert]
(  
	@Name Varchar(50),
	@Id  BIGINT OUTPUT
)
AS
BEGIN	
	
	INSERT INTO Configuration.PaymentMode(Name,IsActive)
	VALUES(@Name,'True')
   
	SET @Id = @@IDENTITY

END
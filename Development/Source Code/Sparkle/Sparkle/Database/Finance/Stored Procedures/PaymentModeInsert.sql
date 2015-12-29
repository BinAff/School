CREATE PROCEDURE [Finance].[PaymentModeInsert]
(  
	@Name Varchar(50),
	@Id  BIGINT OUTPUT
)
AS
BEGIN	
	
	INSERT INTO Finance.PaymentMode(Name, IsActive)
	VALUES(@Name,'True')
   
	SET @Id = @@IDENTITY

END
CREATE PROCEDURE [Billing].[FineTypeInsert]
(  
	@Name Varchar(50),
	@Id  BIGINT OUTPUT
)
AS
BEGIN	
	
	INSERT INTO Billing.FineType(Name, IsActive)
	VALUES(@Name, 'True')
   
	SET @Id = @@IDENTITY

END
CREATE PROCEDURE [Billing].[FeeGroupInsert]
(  
	@Name VARCHAR(50),
	@FrequencyId BIGINT,
	@Id BIGINT OUTPUT
)
AS
BEGIN	
	
	INSERT INTO Billing.FeeGroup(Name, FrequencyId, IsActive)
	VALUES(@Name, @FrequencyId, 'True')
   
	SET @Id = @@IDENTITY
	
END
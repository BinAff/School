CREATE PROCEDURE Billing.FeeGroupInsert
(  
	@Id BIGINT,
	@Name VARCHAR(50),
	@FrequencyId BIGINT
)
AS
BEGIN	
	
	INSERT INTO Billing.FeeGroup(Name, FrequencyId, IsActive)
	VALUES(@Name, @FrequencyId, 'True')
   
	SET @Id = @@IDENTITY
	
END
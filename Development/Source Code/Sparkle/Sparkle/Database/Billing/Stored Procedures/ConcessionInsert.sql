CREATE PROCEDURE [Billing].[ConcessionInsert]
(  
	@Amount NUMERIC(10,2),
	@IsPercentage BIT,
	@FeeId BIGINT,
	@CasteId BIGINT,	
	@Id BIGINT OUTPUT
)
AS
BEGIN	
	
	INSERT INTO Billing.Concession(Amount, IsPercentage, FeeId, CasteId, IsActive)
	VALUES(@Amount, @IsPercentage, @FeeId, @CasteId, 'True')
   
	SET @Id = @@IDENTITY
	
END
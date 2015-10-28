CREATE PROCEDURE [Accountant].[TaxUpdate]
(
	@Id Numeric(10,0),
	@Name Varchar(50),
	@Amount Money,
	@IsPercentage Bit
)
AS
BEGIN
	
	UPDATE Accountant.Tax
	SET	
		Name = @Name,	
		Amount = @Amount,
		IsPercentage = @IsPercentage
	WHERE Id = @Id
   
END
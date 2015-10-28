CREATE PROCEDURE Accountant.InvoiceLineItemTaxInsert
( 
	@LineItemId Numeric(10,0),
	@TaxName Varchar(50), 
	@TaxAmount money, 
	@IsPercentage Bit,
	@Id Numeric(10,0) OUTPUT
)
AS
BEGIN 

	INSERT INTO Accountant.InvoiceLineItemTax(TaxName, TaxAmount, IsPercentage, LineItemId)
	VALUES(@TaxName, @TaxAmount, @IsPercentage, @LineItemId)

	SET @Id = @@IDENTITY
	
END
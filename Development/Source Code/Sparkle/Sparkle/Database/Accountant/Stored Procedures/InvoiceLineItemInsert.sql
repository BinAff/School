CREATE PROCEDURE [Accountant].[InvoiceLineItemInsert]
(  
	@Start DateTime,
	@End DateTime,
	@Description Varchar(250),
	@UnitRate Money,
	@Count Int,
	@InvoiceId Numeric(10,0),
	@ExtraRate Money,
	@ExtraCount Int,
	@Id  Numeric(10,0) OUTPUT
)
AS
BEGIN	
	
	INSERT INTO Accountant.InvoiceLineItem(Start, [End], [Description], UnitRate,[Count], ExtraRate, ExtraCount, InvoiceId)
	VALUES(@Start, @End, @Description, @UnitRate, @Count, @ExtraRate, @ExtraCount, @InvoiceId)
   
	SET @Id = @@IDENTITY
	
END
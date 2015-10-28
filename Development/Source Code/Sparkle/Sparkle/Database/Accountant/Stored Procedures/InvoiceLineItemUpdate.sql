CREATE PROCEDURE [Accountant].[InvoiceLineItemUpdate]
(
	@Id Numeric(10,0),
	@Start DateTime,
	@End DateTime,
	@Description Varchar(250),
	@UnitRate Money,
	@Count Int,
	@ExtraRate Money,
	@ExtraCount Int
)
AS
BEGIN
	
	UPDATE Accountant.InvoiceLineItem
	SET	
		Start = @Start,
		[End] = @End,
		[Description] = @Description,
		UnitRate = @UnitRate,
		[Count] = @Count,
		ExtraRate = @ExtraRate,
		ExtraCount = @ExtraCount
	WHERE Id = @Id
   
END
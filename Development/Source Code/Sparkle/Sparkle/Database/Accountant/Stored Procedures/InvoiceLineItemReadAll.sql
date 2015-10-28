CREATE PROCEDURE [Accountant].[InvoiceLineItemReadAll]
AS
BEGIN
	
	SELECT Id, Start, [End],
		[Description], UnitRate, [Count], ExtraRate, ExtraCount
	FROM Accountant.InvoiceLineItem WITH (NOLOCK)
   
END
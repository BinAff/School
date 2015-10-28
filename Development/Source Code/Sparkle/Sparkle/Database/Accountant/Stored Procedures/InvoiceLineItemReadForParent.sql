CREATE PROCEDURE [Accountant].[InvoiceLineItemReadForParent]
(
	@ParentId Numeric(10,0)
)
AS
BEGIN
	
	SELECT Id, Start, [End],
		[Description], UnitRate, [Count], ExtraRate, ExtraCount
	FROM Accountant.InvoiceLineItem WITH (NOLOCK)
	WHERE InvoiceId = @ParentId
	
END
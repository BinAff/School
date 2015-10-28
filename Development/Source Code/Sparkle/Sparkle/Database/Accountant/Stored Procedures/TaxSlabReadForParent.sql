create PROCEDURE Accountant.TaxSlabReadForParent
(
	@ParentId Numeric(10,0)
)
AS
BEGIN
	
	SELECT TaxId Id, Limit, Amount, StartDate, EndDate
	FROM Accountant.TaxSlab WITH (NOLOCK)
	WHERE TaxId = @ParentId	
	
END
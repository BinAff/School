create PROCEDURE Accountant.TaxSlabReadAll
AS
BEGIN
	
	SELECT TaxId, Limit, Amount, StartDate, EndDate
	FROM Accountant.TaxSlab WITH (NOLOCK)	
	
END
create PROCEDURE Accountant.TaxSlabRead
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	SELECT TaxId, Limit, Amount, StartDate, EndDate
	FROM Accountant.TaxSlab WITH (NOLOCK)
	WHERE TaxId = @Id	
	
END
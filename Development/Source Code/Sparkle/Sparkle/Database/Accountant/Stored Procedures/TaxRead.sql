CREATE PROCEDURE [Accountant].[TaxRead]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	SELECT Id, Name, Amount, IsPercentage
	FROM Accountant.Tax WITH (NOLOCK)
	WHERE Id = @Id
	
END
CREATE PROCEDURE [Accountant].[TaxReadAll]
AS
BEGIN
	
	SELECT Id, Name, Amount, IsPercentage
	FROM Accountant.Tax WITH (NOLOCK)
   
END
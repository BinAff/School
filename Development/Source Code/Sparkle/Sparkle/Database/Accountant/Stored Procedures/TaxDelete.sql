CREATE PROCEDURE Accountant.[TaxDelete]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM Accountant.Tax
	WHERE Id = @Id   
   
END
CREATE PROCEDURE [Finance].[AccountingYearDelete]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM Finance.AccountingYear
	WHERE Id = @Id   
   
END
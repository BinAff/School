
CREATE PROCEDURE [Finance].[AccountingYearUpdate]
(
	@Id Numeric(10,0),
	@Name Varchar(50),
	@CurrentFlag BIT
)
AS

BEGIN
	
	UPDATE Finance.AccountingYear
	SET	
		Name = @Name,
		CurrentFlag = @CurrentFlag
		WHERE Id = @Id
   END
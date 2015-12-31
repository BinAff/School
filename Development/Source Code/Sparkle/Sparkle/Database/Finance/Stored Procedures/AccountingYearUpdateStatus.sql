CREATE PROCEDURE [Finance].[AccountingYearUpdateStatus]
(
	@Id Numeric(10,0),
	@IsActive BIT
)
AS
BEGIN
	
	UPDATE Finance.AccountingYear
	SET	
		IsActive = @IsActive
	WHERE Id = @Id

END
CREATE PROCEDURE [Finance].[AccountingYearInsert]
(  
	@Name Varchar(50),
	@CurrentFlag BIT,
	@Id  Numeric(10,0) OUTPUT
)
AS
BEGIN	
	
	INSERT INTO Finance.AccountingYear(Name,CurrentFlag)
	VALUES(@Name,@CurrentFlag)
   
	SET @Id = @@IDENTITY

END
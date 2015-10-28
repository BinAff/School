create PROCEDURE Accountant.[TaxInsert]
(  
	@Name Varchar(50),
	@Amount Money,
	@IsPercentage Bit,
	@Id  Numeric(10,0) OUTPUT
)
AS
BEGIN	
	
	INSERT INTO  Accountant.Tax([Name],[Amount],[IsPercentage])
	VALUES(@Name,@Amount,@IsPercentage)
   
	SET @Id = @@IDENTITY
END
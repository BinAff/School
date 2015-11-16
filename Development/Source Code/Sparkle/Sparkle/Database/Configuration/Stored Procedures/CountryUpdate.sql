CREATE PROCEDURE Configuration.CountryUpdate
(
	@Id Numeric(10,0),
	@Name Varchar(50),
	@Code Varchar(50),
	@IsdCode Varchar(50)
)
AS
BEGIN
	
	UPDATE Configuration.Country
	SET	
		Name = @Name,
		Code = @Code,
		IsdCode = @IsdCode
	WHERE Id = @Id
   
END
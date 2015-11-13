CREATE PROCEDURE Configuration.CasteInsert
(  
	@Name Varchar(50),
	@ReligionId numeric(10,0),
	@Id  Numeric(10,0) OUTPUT
)
AS
BEGIN	
	
	INSERT INTO Configuration.Caste(Name,ReligionId)
	VALUES(@Name,@ReligionId)
   
	SET @Id = @@IDENTITY

END
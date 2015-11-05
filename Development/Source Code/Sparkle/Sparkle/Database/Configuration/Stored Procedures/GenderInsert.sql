CREATE PROCEDURE Configuration.GenderInsert
(  
	@Name Varchar(50),
	@Id  Numeric(10,0) OUTPUT
)
AS
BEGIN	
	
	INSERT INTO Configuration.Gender(Name)
	VALUES(@Name)
   
	SET @Id = @@IDENTITY

END
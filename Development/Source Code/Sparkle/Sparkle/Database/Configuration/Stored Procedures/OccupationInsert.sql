CREATE PROCEDURE [Configuration].[OccupationInsert]
(  
	@Name Varchar(50),
	@Id  Numeric(10,0) OUTPUT
)
AS
BEGIN	
	
	INSERT INTO Configuration.Occupation(Name)
	VALUES(@Name)
   
	SET @Id = @@IDENTITY

END
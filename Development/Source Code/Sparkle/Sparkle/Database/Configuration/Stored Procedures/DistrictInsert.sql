CREATE PROCEDURE [Configuration].[DistrictInsert]
(  
	@Name Varchar(50),
	@StateId Numeric (10,0),
	@Id  Numeric(10,0) OUTPUT
)
AS
BEGIN	
	
	INSERT INTO Configuration.District(Name,StateId)
	VALUES(@Name,@StateId)
   
	SET @Id = @@IDENTITY

END
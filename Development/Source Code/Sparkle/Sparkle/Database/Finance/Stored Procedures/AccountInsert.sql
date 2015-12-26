CREATE PROCEDURE [Finance].[AccountInsert]
(  
	@Name Varchar(50),
	@OrganizationId Numeric(10,0),
	@Id  Numeric(10,0) OUTPUT
)
AS
BEGIN	
	
	INSERT INTO Finance.Account(Name,OrganizationId)
	VALUES(@Name,@OrganizationId)
   
	SET @Id = @@IDENTITY

END
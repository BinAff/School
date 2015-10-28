CREATE PROCEDURE [Organization].[FaxInsert]
(  
	@Fax Varchar(50),
	@OrganizationId Numeric(10,0),
	@Id  Numeric(10,0) OUTPUT
)
AS
BEGIN	
	
	INSERT INTO [Organization].Fax(Fax,[OrganizationId])
	VALUES(@Fax,@OrganizationId)
   
	SET @Id = @@IDENTITY
END
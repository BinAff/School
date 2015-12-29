
CREATE PROCEDURE [Finance].[AccountUpdate]
(
	@Id Numeric(10,0),
	@Name Varchar(50),
	@OrganizationId Numeric(10,0)	
)
AS

BEGIN
	
	UPDATE Finance.Account
	SET	
		Name = @Name,
		OrganizationId = @OrganizationId
		WHERE Id = @Id
   END
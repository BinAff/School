CREATE PROCEDURE [Finance].[AccountReadDuplicate]
(
	@Name Varchar(50),
	@OrganizationId Numeric(10,0)
)
AS
BEGIN

	SELECT Id
	FROM Finance.Account WITH (NOLOCK)
	WHERE Name = @Name
	and OrganizationId = @OrganizationId
				
END
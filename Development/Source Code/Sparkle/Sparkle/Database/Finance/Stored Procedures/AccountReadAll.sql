
CREATE PROCEDURE [Finance].[AccountReadAll]
AS
BEGIN
	
	SELECT Id, Name,OrganizationId
	FROM Finance.Account WITH (NOLOCK)
   
END
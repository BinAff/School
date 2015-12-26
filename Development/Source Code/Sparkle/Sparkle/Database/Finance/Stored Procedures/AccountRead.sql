CREATE PROCEDURE [Finance].[AccountRead]
(
   @Id Numeric(10,0)
)
AS
BEGIN
	
   SELECT Id, Name,OrganizationId
   FROM Finance.Account WITH (NOLOCK)
   WHERE Id = @Id
   
END
CREATE PROCEDURE [Finance].[PaymentModeRead]
(
   @Id BIGINT
)
AS
BEGIN
	
   SELECT Id, Name, IsActive
   FROM Finance.PaymentMode WITH (NOLOCK)
   WHERE Id = @Id
   
END
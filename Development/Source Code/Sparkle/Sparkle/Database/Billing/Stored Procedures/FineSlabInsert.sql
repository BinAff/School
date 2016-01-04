CREATE PROCEDURE [Billing].[FineSlabInsert]
(  
	@FineId BIGINT,
	@LowerLimit BIGINT = NULL,
	@UpperLimit BIGINT = NULL,
	@Value BIGINT,
	@Id  BIGINT OUTPUT
)
AS
BEGIN	
	
	INSERT INTO Billing.FineSlab(FineId,LowerLimit,UpperLimit,Value,IsActive)
	VALUES(@FineId,@LowerLimit,@UpperLimit,@Value,1)
   
	SET @Id = @@IDENTITY

END
CREATE PROCEDURE [Configuration].[DistrictRead]
(
   @Id Numeric(10,0)
)
AS
BEGIN
	
   SELECT Id, Name, StateId
   FROM Configuration.District WITH (NOLOCK)
   WHERE Id = @Id
   
END
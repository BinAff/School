
CREATE PROCEDURE [Configuration].[FrequencyRead]
(
   @Id Numeric(10,0)
)
AS
BEGIN
	
   SELECT Id, Name,IsActive
   FROM Configuration.Frequency WITH (NOLOCK)
   WHERE Id = @Id
   
END
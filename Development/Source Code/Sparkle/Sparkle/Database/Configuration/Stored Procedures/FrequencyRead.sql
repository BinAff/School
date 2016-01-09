
CREATE PROCEDURE [Configuration].[FrequencyRead]
(
   @Id BIGINT
)
AS
BEGIN
	
   SELECT Id, Name, IsActive
   FROM Configuration.Frequency WITH (NOLOCK)
   WHERE Id = @Id
   
END
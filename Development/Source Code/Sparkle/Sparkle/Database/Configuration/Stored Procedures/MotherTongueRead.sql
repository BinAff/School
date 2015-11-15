CREATE PROCEDURE [Configuration].[MotherTongueRead]
(
   @Id Numeric(10,0)
)
AS
BEGIN
	
   SELECT Id, Name
   FROM Configuration.MotherTongue WITH (NOLOCK)
   WHERE Id = @Id
   
END
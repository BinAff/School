CREATE PROCEDURE [Configuration].[SubCasteRead]
(
   @Id Numeric(10,0)
)
AS
BEGIN
	
   SELECT Id, Name
   FROM Configuration.SubCaste WITH (NOLOCK)
   WHERE Id = @Id
   
END
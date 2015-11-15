CREATE PROCEDURE [Configuration].[DistrictDelete]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM Configuration.District
	WHERE Id = @Id   
   
END
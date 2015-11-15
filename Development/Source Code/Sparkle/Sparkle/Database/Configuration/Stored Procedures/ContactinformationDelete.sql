CREATE PROCEDURE [Configuration].[ContactInformationDelete]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	DELETE 		
	FROM Configuration.ContactInformation
	WHERE Id = @Id   
   
END
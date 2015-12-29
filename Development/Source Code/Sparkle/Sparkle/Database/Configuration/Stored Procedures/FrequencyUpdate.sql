CREATE PROCEDURE [Configuration].[FrequencyUpdate]
(
	@Id Numeric(10,0),
	@Name Varchar(50)
	)
AS

BEGIN
	
	UPDATE Configuration.Frequency
	SET	
		Name = @Name
		WHERE Id = @Id
   END
CREATE PROCEDURE [Configuration].[FrequencyUpdate]
(
	@Id BIGINT,
	@Name Varchar(50)
)
AS
BEGIN
	
	UPDATE Configuration.Frequency
	SET	
		Name = @Name
	WHERE Id = @Id
END
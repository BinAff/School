CREATE PROCEDURE [Configuration].[FrequencyInsert]
(  
	@Name Varchar(50),
	@IsActive BIT,
	@Id  BIGINT OUTPUT
)
AS
BEGIN	
	
	INSERT INTO Configuration.Frequency(Name,IsActive)
	VALUES(@Name,@IsActive)
   
	SET @Id = @@IDENTITY

END
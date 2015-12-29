CREATE PROCEDURE [Configuration].[FrequencyInsert]
(  
	@Name Varchar(50),
	@Id  BIGINT OUTPUT
)
AS
BEGIN	
	
	INSERT INTO Configuration.Frequency(Name,IsActive)
	VALUES(@Name,'True')
   
	SET @Id = @@IDENTITY

END
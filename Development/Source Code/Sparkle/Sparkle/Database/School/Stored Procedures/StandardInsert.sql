CREATE PROCEDURE [School].[StandardInsert]
(  
	@Name VARCHAR(50),
	@Id  BIGINT OUTPUT
)
AS
BEGIN	
	
	INSERT INTO School.Standard(Name, IsActive)
	VALUES(@Name, 'True')
   
	SET @Id = @@IDENTITY
	
END
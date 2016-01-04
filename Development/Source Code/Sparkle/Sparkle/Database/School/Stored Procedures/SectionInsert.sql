CREATE PROCEDURE [School].[SectionInsert]
(  
	@Name VARCHAR(50),
	@Id  BIGINT OUTPUT
)
AS
BEGIN	
	
	INSERT INTO School.Section(Name, IsActive)
	VALUES(@Name, 'True')
   
	SET @Id = @@IDENTITY
	
END
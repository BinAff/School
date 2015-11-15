CREATE PROCEDURE [Configuration].[RelationshipInsert]
(  
	@Name Varchar(50),
	@Id  Numeric(10,0) OUTPUT
)
AS
BEGIN	
	
	INSERT INTO Configuration.Relationship(Name)
	VALUES(@Name)
   
	SET @Id = @@IDENTITY

END
CREATE PROCEDURE [Configuration].[IdentityProofTypeUpdate]
(
	@Id Numeric(10,0),
	@Name Varchar(50)
)
AS
BEGIN
	
	UPDATE [Configuration].IdentityProofType
	SET	
		[Name] = @Name	
	WHERE Id = @Id
   
END
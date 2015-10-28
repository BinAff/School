CREATE PROCEDURE [License].[ModuleUpdate]
(
	@Id  Numeric(10,0),
	@Code Varchar(50),
	@Name Varchar(50),
	@Description Varchar(50),
	@IsMandatory Bit
)
As
Begin
	UPDATE License.Module
	SET Code = @Code,
		Name = @Name,
		[Description] = @Description,
		IsMandatory = @IsMandatory
	WHERE Id = @Id
End
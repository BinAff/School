CREATE PROCEDURE [License].[ComponentUpdate]
(
	@Id  Numeric(10,0),
	@Code Varchar(50),
	@Name Varchar(50),
	@Description Varchar(50),
	@IsForm Bit,
	@IsReport Bit,
	@IsCatalogue Bit
)
As
Begin
	UPDATE License.Component
	SET Code = @Code,
		Name = @Name,
		[Description] = @Description,
		IsForm = @IsForm,
		IsReport = @IsReport,
		IsCatalogue = @IsCatalogue
	WHERE Id = @Id
End
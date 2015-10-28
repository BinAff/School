CREATE PROCEDURE [License].[ComponentInsert]
(
	@Name Varchar(50),
	@Code Varchar(50),
	@Description Varchar(50),
	@IsForm Bit,
	@IsReport Bit,
	@IsCatalogue Bit,
	@Id  Numeric(10,0) OUTPUT
)
As
Begin
	INSERT INTO License.Component(Code, Name, [Description], IsForm, IsReport, IsCatalogue)
	VALUES(@Code, @Name, @Description, @IsForm, @IsReport, @IsCatalogue)
	
	SET @Id = @@IDENTITY
End
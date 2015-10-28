CREATE PROCEDURE [License].[ModuleDelete]
(
	@Id  Numeric(10,0)
)
As
Begin
	DELETE FROM License.Module
	WHERE Id = @Id
End
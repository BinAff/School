CREATE PROCEDURE [License].[ModuleRead]
(
	@Id  Numeric(10,0)
)
As
BEGIN

	SELECT Id, Code, Name, [Description], IsMandatory
	FROM License.Module WITH (NOLOCK)
	WHERE Id = @Id
	
END
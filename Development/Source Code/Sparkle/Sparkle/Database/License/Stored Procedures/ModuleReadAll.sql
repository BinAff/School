CREATE PROCEDURE [License].[ModuleReadAll]
As
BEGIN

	SELECT Id, Code, Name, [Description], IsMandatory
	FROM License.Module WITH (NOLOCK)
	
END
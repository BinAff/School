CREATE PROCEDURE [License].[ComponentReadAll]
As
BEGIN

	SELECT Id, Code, Name, [Description], IsForm, IsReport, IsCatalogue
	FROM License.Component WITH (NOLOCK)
	
END
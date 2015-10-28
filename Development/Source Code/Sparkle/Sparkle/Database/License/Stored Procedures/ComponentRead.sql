CREATE PROCEDURE [License].[ComponentRead]
(
	@Id  Numeric(10,0)
)
As
BEGIN

	SELECT Id, Code, Name, [Description], IsForm, IsReport, IsCatalogue
	FROM License.Component WITH (NOLOCK)
	WHERE Id = @Id
	
END
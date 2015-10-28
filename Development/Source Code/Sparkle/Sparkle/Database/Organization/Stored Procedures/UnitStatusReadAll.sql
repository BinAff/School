CREATE PROCEDURE Organization.UnitStatusReadAll
As
BEGIN

	SELECT Id,Name
	FROM Organization.UnitStatus WITH (NOLOCK)
	
End
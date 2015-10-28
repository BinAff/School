CREATE PROCEDURE Organization.UnitTypeReadAll
As
BEGIN

	SELECT Id,Name
	FROM Organization.UnitType WITH (NOLOCK)
	
END
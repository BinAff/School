CREATE PROCEDURE [Guardian].[IsInitialDeletable]
(
	@InitialId NUMERIC(10,0)
)
AS
BEGIN
	SELECT (SELECT LoginId 
		FROM Guardian.Account WITH (NOLOCK)
		WHERE Id = UserId) LoginId, FirstName, LastName
	FROM Guardian.[Profile] WITH (NOLOCK)
	WHERE Initial = @InitialId

 END
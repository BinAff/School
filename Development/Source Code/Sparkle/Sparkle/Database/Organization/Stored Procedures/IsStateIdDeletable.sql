CREATE PROCEDURE [Organization].[IsStateIdDeletable]
(
	@StateId NUMERIC(10,0)
)
AS
BEGIN
	SELECT  Name
	FROM [Organization].Organization
	WHERE StateId = @StateId

 END
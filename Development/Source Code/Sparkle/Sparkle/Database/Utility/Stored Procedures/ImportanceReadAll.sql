CREATE PROCEDURE [Utility].[ImportanceReadAll]
AS
BEGIN
	
	SELECT Id, Name
	FROM Utility.Importance WITH (NOLOCK)
   
END
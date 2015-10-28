CREATE PROCEDURE [Guardian].[ProfileContactNumberReadForParent] 
(
	@ParentId Numeric(10,0)
)
AS
BEGIN

	SELECT 
		Id,
		UserId,		
		ContactNumber
	FROM Guardian.ProfileContactNumber
	WHERE UserId = @ParentId
	
END
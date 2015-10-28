CREATE PROCEDURE [Guardian].[ProfileContactNumberRead] 
(
	@Id Numeric(10,0)
)
AS
BEGIN

	SELECT 
		Id,
		UserId,		
		ContactNumber
	FROM Guardian.ProfileContactNumber WITH (NOLOCK)
	WHERE Id = @Id
	
END
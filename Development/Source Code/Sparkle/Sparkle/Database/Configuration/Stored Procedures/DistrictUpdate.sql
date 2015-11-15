CREATE PROCEDURE [Configuration].[DistrictUpdate]
(
	@Id Numeric(10,0),
	@Name Varchar(50),
	@StateId Numeric (10,0)
)
AS

BEGIN
	
	UPDATE Configuration.District
	SET	
		Name = @Name,
		StateId = @StateId
		WHERE Id = @Id
   END
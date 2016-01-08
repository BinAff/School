
CREATE PROCEDURE [Admission].[TestDefinitionUpdateStatus]
(
	@Id BIGINT,
	@IsActive BIT
)
AS
BEGIN
	
	UPDATE Admission.TestDefinition
	SET	
		IsActive = @IsActive
	WHERE Id = @Id

END
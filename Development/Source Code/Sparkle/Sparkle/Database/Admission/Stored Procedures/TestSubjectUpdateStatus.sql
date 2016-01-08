CREATE PROCEDURE [Admission].[TestSubjectUpdateStatus]
(
	@Id BIGINT,
	@IsActive BIT
)
AS
BEGIN
	
	UPDATE Admission.TestSubject
	SET	
		IsActive = @IsActive
	WHERE Id = @Id

END
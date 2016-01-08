CREATE PROCEDURE [Admission].[TestDefinitionUpdate]
(
    @Id BIGINT,
	@Name Varchar(50),
	@PassingMarks BIGINT
	)
AS

BEGIN
	
	UPDATE Admission.TestDefinition
	SET	
	 Name = @Name,
	 PassingMarks = @PassingMarks
	 WHERE Id = @Id
   END
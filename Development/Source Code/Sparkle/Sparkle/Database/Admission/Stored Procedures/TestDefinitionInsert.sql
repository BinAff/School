CREATE PROCEDURE [Admission].[TestDefinitionInsert]
(  
	@Name Varchar(50),
	@PassingMarks BIGINT,
	@Id BIGINT OUTPUT
	)
AS
BEGIN	
	
	INSERT INTO Admission.TestDefinition(Name,PassingMarks,IsActive)
	VALUES(@Name,@PassingMarks,1)
   
	SET @Id = @@IDENTITY

END
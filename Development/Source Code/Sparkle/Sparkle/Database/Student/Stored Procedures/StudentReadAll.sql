CREATE PROCEDURE [Student].[StudentReadAll]
As
BEGIN

	SELECT  Id,StudentId,FirstName,MiddleName,LastName,RollNumber,Photo,CategoryId,ClassId
	FROM Student.Student WITH (NOLOCK)
	
END
create PROCEDURE [Utility].[AppointmentTypeReadDuplicate]
(
	@Name VARCHAR(150)		
)
AS
BEGIN
	SELECT Id	
	FROM Utility.AppointmentType
	WHERE Name = @Name				
END
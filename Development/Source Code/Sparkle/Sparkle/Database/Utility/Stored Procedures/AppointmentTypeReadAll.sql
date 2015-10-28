CREATE PROCEDURE [Utility].[AppointmentTypeReadAll]
AS
BEGIN
	
	SELECT Id, Name
	FROM Utility.AppointmentType WITH (NOLOCK)
   
END
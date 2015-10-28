CREATE PROCEDURE [Utility].[AppointmentReadAll]
AS
BEGIN
	
	SELECT Id, ActorId, Title,TypeId,[Start],[End]
		,[Location],[Description],[ImportanceId],[Reminder]
	FROM Utility.Appointment WITH (NOLOCK)
   
END
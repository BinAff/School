CREATE PROCEDURE [Utility].[AppointmentSearch]
( 
	@Start Datetime,
	@End Datetime
)
AS
BEGIN
	
	SELECT Id, ActorId, Title,TypeId,[Start],[End]
           ,[Location],[Description],[ImportanceId],[Reminder]
	FROM Utility.Appointment
	WHERE [Start] >= @Start AND [Start] <= @End AND [End] <= @End
   
END
CREATE PROCEDURE [Utility].[AppointmentRead]
(
	@Id Numeric(10,0)
)
AS
BEGIN
	
	SELECT Id, ActorId, Title,TypeId,[Start],[End]
		,[Location],[Description],[ImportanceId],[Reminder]
	FROM Utility.Appointment WITH (NOLOCK)
	WHERE Id = @Id   
	
END
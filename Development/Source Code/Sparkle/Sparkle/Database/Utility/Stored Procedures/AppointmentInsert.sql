CREATE PROCEDURE [Utility].[AppointmentInsert]
(  
	@ActorId Numeric(10, 0),
	@Title Varchar(50),
	@TypeId Numeric(10,0),
	@Start Datetime,
	@End Datetime,
	@Location Varchar(50),
	@Description Varchar(250),
	@ImportanceId Numeric(10,0) = null,
	@Reminder Datetime = null,
	@Id  Numeric(10,0) OUTPUT
)
AS
BEGIN	
	INSERT INTO [AutoTourism].[Utility].[Appointment]
		(ActorId, Title, TypeId, Start, [End], Location, [Description], ImportanceId, Reminder)
    VALUES
		(@ActorId, @Title, @TypeId, @Start, @End, @Location, @Description, @ImportanceId, @Reminder)
		
	SET @Id = @@IDENTITY
END
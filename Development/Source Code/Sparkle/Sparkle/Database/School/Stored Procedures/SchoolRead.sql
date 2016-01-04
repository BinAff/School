CREATE PROCEDURE School.SchoolRead
(
	@Id Numeric(10,0) = null
)
AS
BEGIN

	SELECT Top 1
		Id, Name, ContactInformationId, Logo, [Tan]
	FROM School.School WITH (NOLOCK)
	
END
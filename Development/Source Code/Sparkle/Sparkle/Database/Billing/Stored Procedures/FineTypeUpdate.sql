CREATE PROCEDURE Billing.FineTypeUpdate
(
	@Id BIGINT,
	@Name Varchar(50)
)
AS
BEGIN
	
	UPDATE Billing.FineType
	SET	
		Name = @Name
	WHERE Id = @Id
END
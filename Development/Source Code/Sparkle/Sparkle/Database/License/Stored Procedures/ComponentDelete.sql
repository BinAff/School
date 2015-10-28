CREATE PROCEDURE [License].[ComponentDelete]
(
	@Id  Numeric(10,0)
)
As
Begin
	DELETE FROM License.Component
	WHERE Id = @Id
End
﻿CREATE PROCEDURE [Configuration].[GenderRead]
(
   @Id Numeric(10,0)
)
AS
BEGIN
	
   SELECT Id, Name, IsActive
   FROM Configuration.Gender WITH (NOLOCK)
   WHERE Id = @Id   
   
END
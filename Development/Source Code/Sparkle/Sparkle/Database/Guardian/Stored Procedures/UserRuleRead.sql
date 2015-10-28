CREATE PROCEDURE [Guardian].[UserRuleRead] 
(  
   @Id Numeric(10,0)  
)  
AS  
BEGIN  
   
	SELECT DefaultPassword	
	FROM UserRule WITH (NOLOCK)
 
END
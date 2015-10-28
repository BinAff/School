CREATE PROCEDURE [Configuration].[RuleRead]
(  
   @Id Numeric(10,0)  
)  
AS  
BEGIN  
   
	Select DateFormat	
	From Configuration.[Rule] WITH (NOLOCK)
 
END
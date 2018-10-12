
/*
	EXEC usp_getForCustomerItem
*/

ALTER PROC usp_getForCustomerItem
AS
BEGIN
	SELECT C.CustomerId,RTRIM(LTRIM(CAST(C.CustomerId AS VARCHAR(5)) + ' - ' + C.FirstName + ' ' + ISNULL(C.LastName,''))) [CustomerName]	
	FROM [dbo].[CUSTOMER] C WITH(NOLOCK)
END
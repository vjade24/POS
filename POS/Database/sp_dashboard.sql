USE [pos_db]
GO
/****** Object:  StoredProcedure [dbo].[sp_dashboard]    Script Date: 6/28/2023 10:38:26 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER PROCEDURE [dbo].[sp_dashboard]
	@par_date DATE 
AS
BEGIN
	SELECT 
	 FORMAT(ISNULL((SELECT SUM(TotalAmount) FROM TransactionDetails),0),'###,##0.00') AS total_income
	,FORMAT(ISNULL((SELECT SUM(TotalAmount) FROM TransactionDetails WHERE CONVERT(date,CreatedAt) = CONVERT(date,@par_date)),0),'###,##0.00') AS total_income_today
	,FORMAT(ISNULL((SELECT COUNT(DISTINCT CustomerName) FROM TransactionHeader),0),'###,##0') AS total_customer
	,FORMAT(ISNULL((SELECT COUNT(DISTINCT CustomerName) FROM TransactionHeader WHERE CONVERT(date,CreatedAt) = CONVERT(date,@par_date)),0),'###,##0') AS total_customer_today
	,FORMAT(ISNULL((SELECT COUNT(*) FROM Supplier),0),'###,##0') AS total_supplier
	,FORMAT(ISNULL((SELECT COUNT(*) FROM Supplier WHERE CONVERT(date,CreatedAt) = CONVERT(date,@par_date)),0),'###,##0') AS total_supplier_today
	,FORMAT(ISNULL((SELECT COUNT(*) FROM Product),0),'###,##0') AS total_products
	,FORMAT(ISNULL((SELECT COUNT(*) FROM Product WHERE CONVERT(date,CreatedAt) = CONVERT(date,@par_date)),0),'###,##0') AS total_products_today
END


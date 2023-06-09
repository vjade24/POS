USE [pos_db]
GO
/****** Object:  StoredProcedure [dbo].[sp_dashboard_not_admin]    Script Date: 6/28/2023 10:39:06 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================  
-- Author:  <Author,,Name>  
-- Create date: <Create Date,,>  
-- Description: <Description,,>  
-- =============================================  
ALTER PROCEDURE [dbo].[sp_dashboard_not_admin]  
 @par_date		DATE,   
 @par_createdby VARCHAR(10)   
AS  
BEGIN  
 SELECT   
  FORMAT(ISNULL((SELECT SUM(TotalAmount) FROM TransactionDetails WHERE CreatedBy = ISNULL(@par_createdby,'')),0),'###,##0.00') AS total_income  
 ,FORMAT(ISNULL((SELECT SUM(TotalAmount) FROM TransactionDetails WHERE CONVERT(date,CreatedAt) = CONVERT(date,@par_date) AND CreatedBy = ISNULL(@par_createdby,'')),0),'###,##0.00') AS total_income_today  
 ,FORMAT(ISNULL((SELECT COUNT(DISTINCT CustomerName) FROM TransactionHeader WHERE CreatedBy = ISNULL(@par_createdby,'')),0),'###,##0') AS total_customer  
 ,FORMAT(ISNULL((SELECT COUNT(DISTINCT CustomerName) FROM TransactionHeader WHERE CONVERT(date,CreatedAt) = CONVERT(date,@par_date) AND CreatedBy = ISNULL(@par_createdby,'')),0),'###,##0') AS total_customer_today  
 ,FORMAT(ISNULL((SELECT COUNT(*) FROM Supplier WHERE CreatedBy = ISNULL(@par_createdby,'')),0),'###,##0') AS total_supplier  
 ,FORMAT(ISNULL((SELECT COUNT(*) FROM Supplier WHERE CONVERT(date,CreatedAt) = CONVERT(date,@par_date) AND CreatedBy = ISNULL(@par_createdby,'')),0),'###,##0') AS total_supplier_today  
 ,FORMAT(ISNULL((SELECT COUNT(*) FROM Product WHERE CreatedBy = ISNULL(@par_createdby,'')),0),'###,##0') AS total_products  
 ,FORMAT(ISNULL((SELECT COUNT(*) FROM Product WHERE CONVERT(date,CreatedAt) = CONVERT(date,@par_date) AND CreatedBy = ISNULL(@par_createdby,'')),0),'###,##0') AS total_products_today  
END  
  
Link: https://leetcode.com/problems/monthly-transactions-i/
Tool: MS SQL Server






SELECT 
SUBSTRING(CONVERT(VARCHAR, trans_date), 1, 7) /*CONVERT(char(7), trans_date, 120) or LEFT(trans_date, 7) or CONVERT(char(7), trans_date) or FORMAT(trans_date, 'yyyy-MM')*/ AS month,
country,
COUNT(id) AS trans_count,
COUNT(CASE WHEN [state] = 'approved' THEN 1 END) AS approved_count,
SUM(amount) AS trans_total_amount,
SUM(CASE WHEN [state] = 'approved' THEN amount ELSE 0 END) AS approved_total_amount

FROM Transactions
GROUP BY SUBSTRING(CONVERT(VARCHAR, trans_date), 1, 7), country
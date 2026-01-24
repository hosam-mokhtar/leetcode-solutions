Link: https://leetcode.com/problems/queries-quality-and-percentage/
Tool: MS SQL Server







SELECT query_name,
ROUND(SUM(rating * 1.0 / position) / COUNT(rating), 2) AS 'quality',
ROUND(COUNT(CASE WHEN rating < 3 THEN rating END) * 1.0 / COUNT(rating) * 100, 2) AS 'poor_query_percentage'
FROM Queries
GROUP BY query_name
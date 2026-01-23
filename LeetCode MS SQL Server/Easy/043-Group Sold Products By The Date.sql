Link: https://leetcode.com/problems/group-sold-products-by-the-date/
Tool: MS SQL Server







WITH DistinctProducts AS (
    SELECT DISTINCT *
    FROM Activities
)
SELECT 
    sell_date,
    COUNT(DISTINCT product) AS num_sold,
    STRING_AGG(product, ',') AS products
FROM DistinctProducts
GROUP BY sell_date
ORDER BY sell_date;
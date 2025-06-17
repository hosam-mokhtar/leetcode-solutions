Link: https://leetcode.com/problems/customer-placing-the-largest-number-of-orders/
Tool: MS SQL Server






SELECT TOP 1 CUSTOMER_NUMBER
FROM ORDERS
GROUP BY CUSTOMER_NUMBER
ORDER BY COUNT(*) DESC
-------------------------------------------------
/*
select top 1 customer_number
from (
select customer_number, count(customer_number) as order_count
from Orders
group by customer_number
) as T
order by order_count desc
*/


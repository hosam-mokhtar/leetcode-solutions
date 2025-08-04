Link: https://leetcode.com/problems/customers-who-bought-all-products/
Tool: MS SQL Server







select customer_id 
from Customer 
group by customer_id 
having count(distinct product_key) = (select count(*) from Product)
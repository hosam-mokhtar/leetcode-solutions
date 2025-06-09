Link: https://leetcode.com/problems/product-sales-analysis-i/
Tool: MS SQL Server






select p.product_name, s.year, s.price 
from Sales s join Product p
on s.product_id = p.product_id 
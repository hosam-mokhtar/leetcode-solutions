Link: https://leetcode.com/problems/list-the-products-ordered-in-a-period/
Tool: MS SQL Server







select p.product_name, sum(o.unit) as unit
from Products p, Orders o
where p.product_id = o.product_id and order_date like '2020-02-%'
group by p.product_name
having sum(o.unit) >= 100
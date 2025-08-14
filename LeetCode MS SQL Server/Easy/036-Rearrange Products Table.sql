Link: https://leetcode.com/problems/rearrange-products-table/
Tool: MS SQL Server






select product_id, store, price
from
    (select product_id, store1, store2, store3 from Products) as store
unpivot
    (price for store in (store1, store2, store3)) as price;
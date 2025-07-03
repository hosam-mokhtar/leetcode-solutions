Link: https://leetcode.com/problems/odd-and-even-transactions/
Tool: MS SQL Server




select transaction_date,
sum(case when amount % 2 != 0 then amount else 0 end) as odd_sum,
sum(case when amount % 2 = 0 then amount else 0 end) as even_sum 
from transactions 
group by transaction_date
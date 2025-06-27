Link: https://leetcode.com/problems/bank-account-summary-ii/
Tool: MS SQL Server






select u.name, sum(t.amount) as balance
from Users u, Transactions t
where u.account = t.account 
group by u.name
having sum(t.amount) > 10000
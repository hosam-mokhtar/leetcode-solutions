Link: https://leetcode.com/problems/calculate-special-bonus/
Tool: MS SQL Server






select employee_id,
(case when [name] like '[^M]%' and employee_id % 2 != 0 then salary else 0 end) as 'bonus' 
from Employees 
order by employee_id
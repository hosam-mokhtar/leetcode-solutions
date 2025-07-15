Link: https://leetcode.com/problems/fix-names-in-a-table/
Tool: MS SQL Server






select user_id,
(upper(substring(name, 1, 1)) + lower(substring(name, 2, len(name) - 1))) as 'name'  
from Users 
order by user_id
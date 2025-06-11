Link: https://leetcode.com/problems/duplicate-emails/
Tool: MS SQL Server






select distinct email as Email
from Person
group by Email
having count(email) > 1
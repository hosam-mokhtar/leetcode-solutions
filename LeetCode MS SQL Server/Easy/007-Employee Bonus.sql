Link: https://leetcode.com/problems/employee-bonus/
Tool: MS SQL Server






select e.name, b.bonus
from Employee e Left join Bonus b
on e.empId = b.empId
where b.bonus < 1000 or b.bonus is null
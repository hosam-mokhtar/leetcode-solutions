Link: https://leetcode.com/problems/employees-with-missing-information/
Tool: MS SQL Server






select isnull(e.employee_id,s.employee_id) as 'employee_id'
from Employees e full outer join Salaries s
on e.employee_id = s.employee_id
where e.name is null or s.salary is null
order by 'employee_id'

Link: https://leetcode.com/problems/primary-department-for-each-employee/
Tool: MS SQL Server






select distinct e.employee_id, e.department_id 
from Employee e
where e.primary_flag = 'Y' or
1 = (select count(department_id) from Employee where employee_id = e.employee_id);
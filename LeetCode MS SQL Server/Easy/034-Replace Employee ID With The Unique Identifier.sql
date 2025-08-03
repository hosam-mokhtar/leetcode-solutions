Link: https://leetcode.com/problems/replace-employee-id-with-the-unique-identifier/
Tool: MS SQL Server






select ei.unique_id, e.name 
from Employees e left outer join EmployeeUNI ei
on e.id = ei.id
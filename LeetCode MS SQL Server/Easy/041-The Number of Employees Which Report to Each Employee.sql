Link: https://leetcode.com/problems/the-number-of-employees-which-report-to-each-employee/
Tool: MS SQL Server






select e.employee_id, e.name, count(r.reports_to) as reports_count, round(avg(r.age * 1.0), 0) as average_age 
from Employees e join Employees r
on e.employee_id = r.reports_to
group by e.employee_id, e.name
order by e.employee_id
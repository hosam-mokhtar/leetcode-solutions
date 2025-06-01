Link: https://leetcode.com/problems/employees-earning-more-than-their-managers/
Tool: MS SQL Server





select e.name  as Employee
from Employee e join Employee e2
on e.managerId = e2.id 
where e.salary > e2.salary
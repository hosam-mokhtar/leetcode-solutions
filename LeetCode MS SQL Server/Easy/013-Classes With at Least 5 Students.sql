Link: https://leetcode.com/problems/classes-with-at-least-5-students/
Tool: MS SQL Server




select class
from Courses
group by class
having count(student) >= 5
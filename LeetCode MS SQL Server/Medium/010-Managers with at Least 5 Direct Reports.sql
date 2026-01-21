Link: https://leetcode.com/problems/managers-with-at-least-5-direct-reports/
Tool: MS SQL Server






SELECT m.name
FROM Employee e JOIN Employee m
ON e.managerId = m.id
GROUP BY m.id, m.name
HAVING COUNT(e.id) > 4
Link: https://leetcode.com/problems/rising-temperature/
Tool: MS SQL Server







select a.id
from Weather a join Weather b
on datediff(day, b.recordDate, a.recordDate) = 1 and a.temperature > b.temperature;
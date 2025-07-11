Link: https://leetcode.com/problems/triangle-judgement/
Tool: MS SQL Server






select x, y, z, 
(case when x + y > z and x + z > y and y + z > x then 'Yes' 
else 'No' end) as triangle 
from Triangle  
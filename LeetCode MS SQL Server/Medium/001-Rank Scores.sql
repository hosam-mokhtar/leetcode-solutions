Link: https://leetcode.com/problems/rank-scores/
Tool: MS SQL Server






select score, DENSE_RANK() over(order by score desc) as rank
from Scores
Link: https://leetcode.com/problems/game-play-analysis-i/
Tool: MS SQL Server




select distinct player_id, MIN(event_date) as first_login
from Activity
GROUP BY player_id
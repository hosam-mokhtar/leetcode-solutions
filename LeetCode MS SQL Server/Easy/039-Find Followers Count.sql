Link: https://leetcode.com/problems/find-followers-count/
Tool: MS SQL Server





select user_id, count(*) as followers_count
from Followers
group by user_id
order by user_id
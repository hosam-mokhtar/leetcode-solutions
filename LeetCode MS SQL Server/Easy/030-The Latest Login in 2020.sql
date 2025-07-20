Link: https://leetcode.com/problems/the-latest-login-in-2020/
Tool: MS SQL Server







select user_id, max(time_stamp) as last_stamp
from Logins
where datepart(year,time_stamp) = 2020
group by user_id
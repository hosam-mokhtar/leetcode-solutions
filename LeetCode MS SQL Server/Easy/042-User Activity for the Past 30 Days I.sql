Link: https://leetcode.com/problems/user-activity-for-the-past-30-days-i/
Tool: MS SQL Server






SELECT 
activity_date AS day, 
count(DISTINCT user_id) AS active_users
FROM Activity
WHERE activity_date BETWEEN DATEADD(DAY, -29, '2019-07-27') /*'2019-06-28'*/ AND '2019-07-27'
GROUP BY activity_date
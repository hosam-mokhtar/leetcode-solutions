Link: https://leetcode.com/problems/analyze-subscription-conversion/
Tool: MS SQL Server






SELECT 
user_id,
ROUND(AVG(CASE WHEN activity_type = 'free_trial' THEN activity_duration * 1.0 END), 2) 
AS trial_avg_duration,
ROUND(AVG(CASE WHEN activity_type = 'paid' THEN activity_duration * 1.0 END), 2) 
AS paid_avg_duration
FROM UserActivity
GROUP BY user_id
HAVING COUNT(CASE WHEN activity_type = 'free_trial' THEN 1 END) > 0 AND
       COUNT(CASE WHEN activity_type = 'paid' THEN 1 END) > 0
ORDER BY user_id;     
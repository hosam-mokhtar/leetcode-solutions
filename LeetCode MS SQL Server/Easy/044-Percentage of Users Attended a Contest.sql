Link: https://leetcode.com/problems/percentage-of-users-attended-a-contest/
Tool: MS SQL Server







DECLARE @USER_COUNT INT
SELECT @USER_COUNT = COUNT(*) FROM Users

SELECT r.contest_id, ROUND(COUNT(r.user_id) * 1.0 / @USER_COUNT * 100, 2) AS [percentage]
FROM Users u, Register r
WHERE u.user_id = r.user_id
GROUP BY r.contest_id
ORDER BY [percentage] DESC, r.contest_id
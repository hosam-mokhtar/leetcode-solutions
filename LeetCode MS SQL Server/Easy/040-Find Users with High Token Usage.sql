Link: https://leetcode.com/problems/find-users-with-high-token-usage/
Tool: MS SQL Server






SELECT user_id, count(prompt) AS prompt_count, round(avg(tokens * 1.0), 2) AS avg_tokens
FROM prompts
GROUP BY user_id
HAVING count(prompt) > 2 AND max(tokens) > avg(tokens) 
ORDER BY avg_tokens DESC
Link: https://leetcode.com/problems/invalid-tweets/
Tool: MS SQL Server






select tweet_id
from Tweets
where len(content) > 15

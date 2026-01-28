Link: https://leetcode.com/problems/delete-duplicate-emails/
Tool: MS SQL Server







DELETE p2
FROM Person p1, Person p2
WHERE p2.id > p1.id AND p1.email = p2.email
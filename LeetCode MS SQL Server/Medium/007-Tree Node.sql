Link: https://leetcode.com/problems/tree-node/
Tool: MS SQL Server





SELECT 
t1.id, 
CASE WHEN t1.p_id IS NULL THEN 'Root' 
     WHEN (SELECT COUNT(t2.p_id) FROM Tree  t2 WHERE t2.p_id = t1.id) = 0 THEN 'Leaf' 
     ELSE 'Inner' END AS type
FROM Tree t1
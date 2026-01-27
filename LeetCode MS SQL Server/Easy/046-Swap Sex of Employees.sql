Link: https://leetcode.com/problems/swap-sex-of-employees/
Tool: MS SQL Server






UPDATE Salary 
SET sex =
CASE 
    WHEN sex = 'f' THEN 'm' 
    ELSE 'f'
END
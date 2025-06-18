Link: https://leetcode.com/problems/swap-salary/
Tool: MS SQL Server






update Salary 
set sex =
case 
    when sex = 'f' then 'm' 
    else 'f'
end
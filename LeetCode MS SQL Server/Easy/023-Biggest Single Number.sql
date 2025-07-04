Link: https://leetcode.com/problems/biggest-single-number/
Tool: MS SQL Server






select max(num) as num
from(
select num
from MyNumbers
group by num
having count(num) = 1
) as T

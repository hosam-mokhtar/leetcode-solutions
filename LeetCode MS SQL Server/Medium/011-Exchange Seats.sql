Link: https://leetcode.com/problems/exchange-seats/
Tool: MS SQL Server







select  case 
             when id % 2 = 0 then id - 1 
             when id = (select count(id) from Seat) then id 
             else id + 1 
        end as id, student
from Seat
order by id